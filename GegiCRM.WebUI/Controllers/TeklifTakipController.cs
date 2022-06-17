using System.Text;
using AutoMapper;
using GegiCRM.BLL.Concrete;
using GegiCRM.BLL.Generic;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GegiCRM.WebUI.Controllers
{
    [Authorize]
    public class TeklifTakipController : Controller
    {
        readonly UserManager<AppUser> _userManager;
        readonly AppUserManager _appUserManager;
        //readonly GenericManager<AppUser> _userman;
        readonly TeklifTakipManager _teklifTakipManager;
        readonly GenericManager<Customer> _customerManager;
        readonly OrdersCurrencyManager _orderCurrencyManager;
        readonly GenericManager<OrderState> _orderStateManager;
        readonly OrdersProductManager _orderProductsManager;
        readonly GenericManager<ProductGroup> _productGroupGenericManager;
        readonly ProductManager _productManager;

        public readonly SignInManager<AppUser> _signInManager;

        readonly IMapper _mapper;

        private GenericManager<Currency> _currencyManager;
        public TeklifTakipController(UserManager<AppUser> userManager, IMapper mapper, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _appUserManager = new AppUserManager(userManager, new EfAppUserRepository(), signInManager);
            _mapper = mapper;
            _signInManager = signInManager;
            _teklifTakipManager = new TeklifTakipManager(userManager, new EfOrderRepository()); ;
            _customerManager = new GenericManager<Customer>(userManager, new EfCustomerRepository());
            _orderCurrencyManager = new OrdersCurrencyManager(userManager, new EfOrdersCurrencyRepository());
            _currencyManager = new GenericManager<Currency>(userManager, new EfCurrencieRepository());
            _orderStateManager = new GenericManager<OrderState>(userManager, new GenericRepository<OrderState>());
            _orderProductsManager = new OrdersProductManager(userManager, new EfOrdersProductRepository(), _signInManager);
            _productGroupGenericManager = new GenericManager<ProductGroup>(userManager, new EfProductGroupRepository());
            _productManager = new ProductManager(userManager, new EfProductRepository());
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

        [HttpPost]
        public IActionResult CreateNewOrder(string customer_Id, string rUser_Id)
        {
            var createdOrder = _teklifTakipManager.Create(customer_Id, rUser_Id);
            //createdOrder.CreatedDate = DateTime.Now;
            return RedirectToAction("Edit", new { createdOrder.Id });
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
        public IActionResult Edit(Order order)
        {

            if (order == null)
            {
                return BadRequest();
            }

            _teklifTakipManager.Update(order);

            return RedirectToAction("Edit", new { id = order.Id });
        }

        public IActionResult _GetOrdersProductsPartial(int id)
        {
            List<OrdersProduct> ordersProducts = _orderProductsManager.GetListByAllNavigations(id);
            return View(ordersProducts);
        }

        public IActionResult _GetOrdersCurrenciesPartial(int id)
        {
            var ordersCurrencies = _orderCurrencyManager.GetOrdersCurrencies(id);
            return View(ordersCurrencies);
        }

        public IActionResult _GetOrdersCurrenciesWithEditing(int id)
        {
            var data = _currencyManager.GetAll(false);
            ViewBag.Currencies = data;
            return View(id);
        }
        [HttpPost]
        public string AddCurrencyToOrder(string orderId, string currencyId, string currencyValue)
        {
            var curId = Convert.ToInt32(currencyId);
            var orId = Convert.ToInt32(orderId);
            var val = Convert.ToDecimal(currencyValue);
            var orderC = _orderCurrencyManager.ListByFilter(x => x.CurrencyId == curId && x.OrderId == orId, false).FirstOrDefault();
            try
            {
                if (orderC == null)
                {

                    decimal value = Convert.ToDecimal(currencyValue);
                    OrdersCurrency currencyToAdd = new OrdersCurrency()
                    {
                        OrderId = orId,
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
        public string DeleteOrdersCurrency(int id)
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
                new GenericManager<Supplier>(_userManager, new EfSupplierRepository());

            GenericManager<Birim> birimGenericManager =
                new GenericManager<Birim>(_userManager, new EfBirimRepository());

            GenericManager<Brand> brandGenericManager =
                new GenericManager<Brand>(_userManager, new EfBrandRepository());

            GenericManager<Currency> currencyGenericManager =
                new GenericManager<Currency>(_userManager, new EfCurrencieRepository());


            AddOrdersProductViewModel vm = new AddOrdersProductViewModel();
            vm.Suppliers = supplierGenericManager.GetAll(false);
            vm.Birims = birimGenericManager.GetAll(false);
            vm.Brands = brandGenericManager.GetAll(false);
            vm.ProductGroups = _productGroupGenericManager.GetAll(false);
            vm.Products = _productManager.GetProductsWithNavigations(false);
            vm.Currencies = currencyGenericManager.GetAll(false);
            vm.OrdersCurrencies = _orderCurrencyManager.GetOrdersCurrencies(id);
            vm.CurrentOrderId = id;
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
                        new GenericManager<Product>(_userManager, new EfProductRepository());
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

        public async Task<IActionResult> Test()
        {
            _teklifTakipManager.Create(new Order
            {
                CustomerId = 1,

            });


            string data = "";
            return Content(data);
        }

        public async Task<string> CalculateSegmentPrice()
        {

            return "";
        }
    }
}
