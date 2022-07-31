using AutoMapper;
using GegiCRM.BLL.Concrete;
using GegiCRM.BLL.Generic;
using GegiCRM.DAL.Concrete;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Models;
using GegiCRM.WebUI.Utils.CustomActionFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace GegiCRM.WebUI.Controllers
{

    [Authorize]
    [ActivityLogger]
    public class TeklifTakipController : Controller
    {
        readonly AppUserManager _appUserManager;
        //readonly GenericManager<AppUser> _userman;
        readonly TeklifTakipManager _teklifTakipManager;
        readonly GenericManager<Customer> _customerManager;
        readonly OrdersProductCurrencyManager _orderCurrencyManager;
        readonly GenericManager<OrderState> _orderStateManager;
        readonly OrdersProductManager _orderProductsManager;
        readonly GenericManager<ProductGroup> _productGroupGenericManager;
        readonly ProductManager _productManager;
        readonly CrmDbContext _context = new CrmDbContext();

        public readonly SignInManager<AppUser> _signInManager;

        readonly IMapper _mapper;

        private GenericManager<Currency> _currencyManager;
        public TeklifTakipController(IMapper mapper, SignInManager<AppUser> signInManager)
        {
            _appUserManager = new AppUserManager(new EfAppUserRepository(), signInManager);
            _mapper = mapper;
            _signInManager = signInManager;
            _teklifTakipManager = new TeklifTakipManager(new EfOrderRepository()); ;
            _customerManager = new GenericManager<Customer>(new EfCustomerRepository());
            _orderCurrencyManager = new OrdersProductCurrencyManager(new EfOrdersCurrencyRepository());
            _currencyManager = new GenericManager<Currency>(new EfCurrencieRepository());
            _orderStateManager = new GenericManager<OrderState>(new GenericRepository<OrderState>());
            _orderProductsManager = new OrdersProductManager(new EfOrdersProductRepository(), _signInManager);
            _productGroupGenericManager = new GenericManager<ProductGroup>(new EfProductGroupRepository());
            _productManager = new ProductManager(new EfProductRepository());
        }

        [Route("SiparisTakip")]
        public IActionResult St()
        {
            return RedirectToAction("Index", new { isOrder = true });
        }

        public IActionResult Index(bool isOrder)
        {
            List<Order> model = _teklifTakipManager.GetListAllWithNavigationsByFilter(x => x.IsOfferApproved == isOrder);
            if (isOrder)
            {
                ViewBag.Type = "Sipariş";
            }
            else
            {
                ViewBag.Type = "Teklif";
            }
            return View(model);
        }


        public async Task<IActionResult> _NewOrderContentPartial()
        {
            ViewBag.Customers = _customerManager.GetAll(false);
            ViewBag.Users = _appUserManager.GetAll(false);
            return View(await _appUserManager.GetCurrentUserAsync());
        }

        public IActionResult CreateNewOrder(string customer_Id, string rUser_Id)
        {
            var createdOrder = _teklifTakipManager.Create(customer_Id, rUser_Id);
            //createdOrder.CreatedDate = DateTime.Now;
            return RedirectToAction("Edit", new { createdOrder.Id });
        }

        public async Task<string> _GetSegmentPrice(int customerId, decimal fiyat, int currencyId, int adet)
        {
            CrmDbContext c = new CrmDbContext();


            var toplam_fiyat = fiyat * adet;

            ICollection<SegmentOran> customersSegmentOrans = c.Customers.FirstOrDefault(x => x.Id == customerId).Segment.SegmentOrans;
            var currentOran = customersSegmentOrans.Where(x => x.StartPrice <= toplam_fiyat && x.EndPrice >= toplam_fiyat && x.CurrencyID == currencyId).FirstOrDefault();

            if (currentOran != null)
            {
                var fkomisyon = ((fiyat / 100) * currentOran.Oran);
                var FiyatGetir = fiyat + fkomisyon;
                return String.Format("{0:N}", FiyatGetir);
            }
            else
            {
                return "Parametre Eksik veya Hatalı !";
            }
            return "OK";
        }

        public IActionResult Edit(int id)
        {
            var order = _teklifTakipManager.GetByIdWithNavigations(id);
            if (order == null)
            {
                return BadRequest();
            }
            ViewBag.Customers = _customerManager.GetAll(false);
            ViewBag.Users = _appUserManager.GetAll(false);
            ViewBag.OrderStates = _orderStateManager.GetAll(false);
            var context = new CrmDbContext();
            ViewBag.OrdersToMove = context.Orders.Include(x => x.Customer).Include(x => x.AddedBy).Include(x => x.RepresentetiveUser).Where(x => x.IsDeleted == false).ToList(); ;

            string type = "Sipariş";
            //offer onaylanmadıysa ve nullsa bu bir tekliftir
            if (order.IsOfferApproved == false)
            {
                type = "Teklif";
            }


            ViewBag.Type = type;

            //ViewBag.OfferStates = data.i;
            return View(order);
        }

        [HttpPost]
        public IActionResult Edit(Order order, string approveAll)
        {

            if (order == null)
            {
                return BadRequest();
            }

            if (approveAll == "1")
            {
                var ordersProducts = _orderProductsManager.GetListByAllNavigations(order.Id);
                foreach (OrdersProduct item in ordersProducts)
                {
                    item.IsApproved = true;
                    _orderProductsManager.Update(item);
                }
            }

            _teklifTakipManager.Update(order);

            return RedirectToAction("Edit", new { id = order.Id });
        }


        public IActionResult _GetOrdersProductsPartial(int id, string type)
        {
            List<OrdersProduct> ordersProducts = _orderProductsManager.GetListByAllNavigations(id);
            if (type != "Teklif")
            {
                ordersProducts = ordersProducts.Where(x => x.IsApproved || x.IsDeneied).ToList();
            }
            return View(ordersProducts);
        }

        public IActionResult _GetOrdersProductCurrenciesPartial(int id)
        {
            var ordersCurrencies = _orderCurrencyManager.GetOrdersProductCurrencies(id);
            return View(ordersCurrencies);
        }

        public IActionResult _GetOrdersProductCurrenciesWithEditing(int id)
        {
            var data = _currencyManager.GetAll(false);
            ViewBag.Currencies = data;
            return View(id);
        }
        [HttpPost]
        public string AddCurrencyToOrder(string orderProductId, string currencyId, string currencyValue)
        {
            var curId = Convert.ToInt32(currencyId);
            var orPId = Convert.ToInt32(orderProductId);
            var val = Convert.ToDecimal(currencyValue);
            var orderC = _orderCurrencyManager.ListByFilter(x => x.CurrencyId == curId && x.OrdersProductId == orPId, false).FirstOrDefault();
            try
            {
                if (orderC == null)
                {

                    decimal value = Convert.ToDecimal(currencyValue);
                    OrdersProductCurrency currencyToAdd = new OrdersProductCurrency()
                    {
                        OrdersProductId = orPId,
                        CurrencyId = curId,
                        Value = val,
                    };

                    _orderCurrencyManager.Create(currencyToAdd);
                }
                else
                {
                    orderC.Value = val;
                    orderC.IsDeleted = false;
                    _orderCurrencyManager.Update(orderC);
                }

                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        [HttpPost]
        public string DeleteOrdersProductsCurrency(int id)
        {

            var orderC = _orderCurrencyManager.ListByFilter(x => x.Id == id, false).FirstOrDefault();
            try
            {
                if (orderC != null)
                {
                    _orderCurrencyManager.Delete(orderC);
                }

                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var orderToDelete = _teklifTakipManager.GetById(id, false);
            if (orderToDelete != null)
            {
                _teklifTakipManager.Delete(orderToDelete);
                return RedirectToAction("Index");
            }

            return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Order Id to add Product</param>
        /// <returns></returns>
        public IActionResult _AddOrdersProductPartial(int id, int? orderProductId)
        {
            GenericManager<Supplier> supplierGenericManager =
                new GenericManager<Supplier>(new EfSupplierRepository());

            GenericManager<Birim> birimGenericManager =
                new GenericManager<Birim>(new EfBirimRepository());

            GenericManager<Brand> brandGenericManager =
                new GenericManager<Brand>(new EfBrandRepository());

            GenericManager<Currency> currencyGenericManager =
                new GenericManager<Currency>(new EfCurrencieRepository());


            AddOrdersProductViewModel vm = new AddOrdersProductViewModel();
            vm.Suppliers = supplierGenericManager.GetAll(false);
            vm.Birims = birimGenericManager.GetAll(false);
            vm.Brands = brandGenericManager.GetAll(false);
            vm.ProductGroups = _productGroupGenericManager.GetAll(false);
            vm.Products = _productManager.GetProductsWithNavigations(false);
            vm.Currencies = currencyGenericManager.GetAll(false);
            vm.CurrentOrderId = id;
            var order = _teklifTakipManager.GetById(id, false);
            string type = "Sipariş";
            //offer onaylanmadıysa ve nullsa bu bir tekliftir
            if (order.IsOfferApproved == false)
            {
                type = "Teklif";
            }
            ViewBag.Type = type;

            if (orderProductId != null)
            {
                vm.OrderProduct = _orderProductsManager.GetListByAllNavigations(id).FirstOrDefault(x => x.Id == orderProductId.Value);
            }
            else
            {
                vm.OrderProduct = new OrdersProduct() { ProductId = -1 };
            }

            return View(vm);
        }

        public async Task<int> CheckForOnayliProducts(int id)
        {
            return _orderProductsManager.GetListByAllNavigations(id).Count(x => x.IsApproved);
        }

        public async Task<string> AddOrdersProduct(OrdersProduct ordersProduct, string orderProductId, string ProductName, string ProductBrandId, string ProductGroupId)
        {
            ordersProduct.Id = Convert.ToInt32(orderProductId);
            StringBuilder errStringBuilder = new StringBuilder();
            if (ordersProduct.ProductId == -1)
            {
                //yeni ürün oalarak ekliyoruz
                if (!(string.IsNullOrWhiteSpace(ProductName) || string.IsNullOrWhiteSpace(ProductBrandId) || string.IsNullOrWhiteSpace(ProductGroupId)))
                {
                    Product product = new Product();
                    product.ProductName = ProductName;
                    product.PorductBrandId = Convert.ToInt32(ProductBrandId);
                    product.ProductGroupId = Convert.ToInt32(ProductGroupId);
                    GenericManager<Product> productGenericManager =
                        new GenericManager<Product>(new EfProductRepository());
                    product = productGenericManager.Create(product);
                    ordersProduct.ProductId = product.Id;
                }
                else
                {
                    errStringBuilder.AppendLine("Hata: Girilen Değerleri Kontrol Edin !  <br />");
                }
            }

            try
            {
                //aha bura
                //todo: buraya bak
                var currentUser = await _orderProductsManager.GetCurrentUserAsync();
                var productGroupId = _productManager.GetById(ordersProduct.ProductId, false)!.ProductGroupId;
                if (productGroupId != null)
                {
                    var productGroup = _productGroupGenericManager.GetById(productGroupId.Value, false);
                    ordersProduct.ReferanceCode = _orderProductsManager.GenerateReferanceCode(currentUser, productGroup);
                }

                if (ordersProduct.Id > 0)
                {
                    _orderProductsManager.Update(ordersProduct);
                    //_context.OrdersProducts.Update(ordersProduct).State = EntityState.Modified;
                    //_context.SaveChanges();
                    return "UP";
                }
                _orderProductsManager.Create(ordersProduct);

                return "OK";
            }
            catch (Exception e)
            {
                errStringBuilder.AppendLine($"Kritik Hata: {e.Message} <br />");
            }

            return errStringBuilder.ToString();

        }


        public async Task<string> DoMultipleAction(int[] ids, string type)
        {
            foreach (int id in ids)
            {
                try
                {
                    var op = _orderProductsManager.GetAll(false).FirstOrDefault(x => x.Id == id);
                    if (op != null)
                    {
                        switch (type)
                        {
                            case "Onay":
                                op.IsDeneied = false;
                                op.IsCancelled = false;
                                op.IsApproved = true;
                                break;
                            case "Iptal":
                                op.IsDeneied = false;
                                op.IsApproved = false;
                                op.IsCancelled = true;
                                break;
                            case "Red":
                                op.IsApproved = false;
                                op.IsCancelled = false;
                                op.IsDeneied = true;
                                break;
                            case "Sil":
                                _orderProductsManager.Delete(op);
                                break;
                        }

                        _orderProductsManager.Update(op);

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }

            return "OK";
        }
        public async Task<string> MoveSelectedOrderProducts(int[] ids, string type, int destinationCustomerId)
        {
            foreach (int id in ids)
            {
                try
                {
                    var c = new CrmDbContext();
                    var op = c.OrdersProducts.FirstOrDefault(x => x.Id == id);
                    if (op != null)
                    {
                        if (type == "cut")
                        {
                            op.OrderId = destinationCustomerId;
                            c.OrdersProducts.Update(op).State = EntityState.Modified;
                            c.SaveChanges();
                            //_orderProductsManager.Update(op);
                        }
                        else
                        {
                            OrdersProduct newOp = new OrdersProduct();
                            var copyCode = "";
                            if (op.ReferanceCode.Split('-').Length > 1)
                            {
                                int copyNumber = Convert.ToInt32(op.ReferanceCode.Split('-')[1]);
                                copyNumber++;
                                copyCode = $"{op.ReferanceCode.Split('-')[0]}-{copyNumber}";
                            }
                            else
                            {
                                copyCode = $"{op.ReferanceCode.Split('-')[0]}-1";
                            }
                            //newOp = _mapper.Map(op, newOp);
                            newOp.ProductId = op.ProductId;
                            newOp.OrderId = destinationCustomerId;
                            newOp.KesinSevkDurumu = op.KesinSevkDurumu;
                            newOp.Adet = op.Adet;
                            newOp.AbonelikBaslangic = op.AbonelikBaslangic;
                            newOp.AbonelikBitis = op.AbonelikBitis;
                            newOp.ApprovedDate = op.ApprovedDate;
                            newOp.BirimId = op.BirimId;
                            newOp.DeniedDate = op.DeniedDate;
                            newOp.KesinSupplierId = op.KesinSupplierId;
                            newOp.IsApproved = op.IsApproved;
                            newOp.IsCancelled = op.IsCancelled;
                            newOp.IsDeleted = op.IsDeleted;
                            newOp.IsDeneied = op.IsDeneied;
                            newOp.Notes = op.Notes;
                            newOp.ReferansBirimFiyat = op.ReferansBirimFiyat;
                            newOp.BirimFiyat = op.BirimFiyat;
                            newOp.ReferansCurrencyId = op.ReferansCurrencyId;
                            newOp.ReferansSupplierId = op.ReferansSupplierId;
                            newOp.ReferansCurrencyValue = op.ReferansCurrencyValue;
                            newOp.ReferansCurrencyValue = op.ReferansCurrencyValue;

                            newOp.ReferanceCode = copyCode;
                            //newOp.OrderId = destinationCustomerId;
                            _orderProductsManager.Create(newOp);
                        }

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }

            return "OK";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">order id!</param>
        /// <returns></returns>
        public IActionResult Copy(int id, bool toplam)
        {
            ViewBag.Toplam = toplam;
            Order? order = _context.Orders.Find(id);
            if (order != null)
            {
                return View(order);
            }

            return NotFound();

        }

        public async Task<IActionResult> _CopyTeklif(int id, bool toplamli)
        {
            List<OrdersProduct>? data = _context.OrdersProducts.Where(x => x.OrderId == id).ToList();
            ViewBag.Toplamli = toplamli;
            ViewBag.TicariUnvan = _teklifTakipManager.GetById(id, false).Customer.TicariUnvan;
            return View(data);
        }

        
        public async Task<IActionResult> AdobeTeklif(int id)
        {
            List<OrdersProduct>? data = _context.OrdersProducts.Where(x => x.OrderId == id).ToList();
            ViewBag.Musteri = _teklifTakipManager.GetById(id, false).Customer;
            ViewBag.Kullanici = await _teklifTakipManager.GetCurrentUserAsync();
            return View(data);
        }
        
        public async Task<IActionResult> ComodoTeklif(int id)
        {
            List<OrdersProduct>? data = _context.OrdersProducts.Where(x => x.OrderId == id).ToList();
            ViewBag.Musteri = _teklifTakipManager.GetById(id, false).Customer;
            ViewBag.Kullanici = await _teklifTakipManager.GetCurrentUserAsync();
            return View(data);
        }

        public async Task<IActionResult> DonanimTeklif(int id)
        {
            List<OrdersProduct>? data = _context.OrdersProducts.Where(x => x.OrderId == id).ToList();
            ViewBag.Musteri = _teklifTakipManager.GetById(id, false).Customer;
            ViewBag.Kullanici = await _teklifTakipManager.GetCurrentUserAsync();
            return View(data);
        }

        public async Task<IActionResult> IskontaliTeklif(int id)
        {
            List<OrdersProduct>? data = _context.OrdersProducts.Where(x => x.OrderId == id).ToList();
            ViewBag.Musteri = _teklifTakipManager.GetById(id, false).Customer;
            ViewBag.Kullanici = await _teklifTakipManager.GetCurrentUserAsync();
            return View(data);
        }

        public async Task<IActionResult> KiralamaTeklif(int id)
        {
            List<OrdersProduct>? data = _context.OrdersProducts.Where(x => x.OrderId == id).ToList();
            ViewBag.Musteri = _teklifTakipManager.GetById(id, false).Customer;
            ViewBag.Kullanici = await _teklifTakipManager.GetCurrentUserAsync();
            return View(data);
        }

        public async Task<IActionResult> ProformaFatura(int id)
        {
            List<OrdersProduct>? data = _context.OrdersProducts.Where(x => x.OrderId == id).ToList();
            ViewBag.Musteri = _teklifTakipManager.GetById(id, false).Customer;
            ViewBag.Kullanici = await _teklifTakipManager.GetCurrentUserAsync();
            return View(data);
        }

        public async Task<IActionResult> QnapTeklif(int id)
        {
            List<OrdersProduct>? data = _context.OrdersProducts.Where(x => x.OrderId == id).ToList();
            ViewBag.Musteri = _teklifTakipManager.GetById(id, false).Customer;
            ViewBag.Kullanici = await _teklifTakipManager.GetCurrentUserAsync();
            return View(data);
        }

        public async Task<IActionResult> SophosTeklif(int id)
        {
            List<OrdersProduct>? data = _context.OrdersProducts.Where(x => x.OrderId == id).ToList();
            ViewBag.Musteri = _teklifTakipManager.GetById(id, false).Customer;
            ViewBag.Kullanici = await _teklifTakipManager.GetCurrentUserAsync();
            return View(data);
        }

        public async Task<IActionResult> TecnoPcTeklif(int id)
        {
            List<OrdersProduct>? data = _context.OrdersProducts.Where(x => x.OrderId == id).ToList();
            ViewBag.Musteri = _teklifTakipManager.GetById(id, false).Customer;
            ViewBag.Kullanici = await _teklifTakipManager.GetCurrentUserAsync();
            return View(data);
        }

        public async Task<IActionResult> TekSayfaDonanimTeklif(int id)
        {
            List<OrdersProduct>? data = _context.OrdersProducts.Where(x => x.OrderId == id).ToList();
            ViewBag.Musteri = _teklifTakipManager.GetById(id, false).Customer;
            ViewBag.Kullanici = await _teklifTakipManager.GetCurrentUserAsync();
            return View(data);
        }

        public async Task<IActionResult> UpsBakimTeklif(int id)
        {
            List<OrdersProduct>? data = _context.OrdersProducts.Where(x => x.OrderId == id).ToList();
            ViewBag.Musteri = _teklifTakipManager.GetById(id, false).Customer;
            ViewBag.Kullanici = await _teklifTakipManager.GetCurrentUserAsync();
            return View(data);
        }



        public async Task<decimal> CalculateSegmentPrice()
        {
            decimal price = 0;
            return price;
        }
    }
}
