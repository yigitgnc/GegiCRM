using AutoMapper;
using GegiCRM.BLL.Concrete;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace GegiCRM.WebUI.Controllers
{
    [Authorize]
    public class TeklifTakipController : Controller
    {
        readonly UserManager<AppUser> _userManager;
        //readonly GenericManager<AppUser> _userman;
        readonly TeklifTakipManager _teklifTakipManager;
        readonly GenericManager<Customer> _customerManager;
        readonly OrdersCurrencyManager _orderCurrencyManager;
        readonly GenericManager<OrderState> _orderStateManager;
        readonly OrdersProductManager _orderProductsManager;
        readonly IMapper _mapper;

        private GenericManager<Currency> _currencyManager;
        public TeklifTakipController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
            _teklifTakipManager = new TeklifTakipManager(_userManager, new EfOrderRepository()); ;
            _customerManager = new GenericManager<Customer>(_userManager, new EfCustomerRepository());
            _orderCurrencyManager = new OrdersCurrencyManager(_userManager, new EfOrdersCurrencyRepository());
            _currencyManager = new GenericManager<Currency>(_userManager, new EfCurrencieRepository());
            _orderStateManager = new GenericManager<OrderState>(_userManager, new GenericRepository<OrderState>());
            _orderProductsManager = new OrdersProductManager(_userManager, new EfOrdersProductRepository());
        }

        [Route("SiparisTakip")]
        public IActionResult St()
        {
            return RedirectToAction("Index",new {isOrder = true});
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

        public IActionResult _NewOrderContentPartial()
        {
            ViewBag.Customers = _customerManager.ListByFilter(x => x.IsDeleted == false);
            ViewBag.Users = _userManager.Users.ToList();
            return View();
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
            ViewBag.Customers = _customerManager.ListByFilter(x => x.IsDeleted == false);
            ViewBag.Users = _userManager.Users.Where(x => x.IsDeleted == false).ToList();
            ViewBag.OrderStates = _orderStateManager.ListByFilter(x => x.IsDeleted == false);

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



            ViewBag.Customers = _customerManager.ListByFilter(x => x.IsDeleted == false);
            ViewBag.Users = _userManager.Users.Where(x => x.IsDeleted == false).ToList();
            ViewBag.OrderStates = _orderStateManager.ListByFilter(x => x.IsDeleted == false);

            string type = "Sipariş";
            //offer onaylanmadıysa ve nullsa bu bir tekliftir
            if (order.IsOfferApproved == false)
            {
                type = "Teklif";
            }

            ViewBag.Type = type;

            //ViewBag.OfferStates = data.i;

            order = _teklifTakipManager.GetByIdWithNavigations(order.Id);
            return View(order);
        }

        public IActionResult _GetOrdersProductsPartial(int id)
        {
            List<OrdersProduct> ordersProducts = _orderProductsManager.ListByFilter(x => x.OrderId == id);
            return View(ordersProducts);
        }

        public IActionResult _GetOrdersCurrenciesPartial(int id)
        {
            var ordersCurrencies = _orderCurrencyManager.GetOrdersCurrencies(id);
            return View(ordersCurrencies);
        }

        public IActionResult _GetOrdersCurrenciesWithEditing(int id)
        {
            var data = _currencyManager.ListByFilter(x => x.IsDeleted == false);
            ViewBag.Currencies = data;
            return View(id);
        }
        [HttpPost]
        public string AddCurrencyToOrder(string orderId, string currencyId, string currencyValue)
        {
            var curId = Convert.ToInt32(currencyId);
            var orId = Convert.ToInt32(orderId);
            var val = Convert.ToDecimal(currencyValue);
            var orderC = _orderCurrencyManager.ListByFilter(x => x.CurrencyId == curId && x.OrderId == orId).FirstOrDefault();
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

            var orderC = _orderCurrencyManager.ListByFilter(x => x.Id == id).FirstOrDefault();
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
            var orderToDelete = _teklifTakipManager.GetById(id);
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

            GenericManager<ProductGroup> productGroupGenericManager =
                new GenericManager<ProductGroup>(_userManager, new EfProductGroupRepository());

            ProductManager productManager = new ProductManager(_userManager, new EfProductRepository());

            GenericManager<Currency> currencyGenericManager =
                new GenericManager<Currency>(_userManager, new EfCurrencieRepository());


            AddOrdersProductViewModel vm = new AddOrdersProductViewModel();
            vm.Suppliers = supplierGenericManager.GetAll();
            vm.Birims = birimGenericManager.GetAll();
            vm.Brands = brandGenericManager.GetAll();
            vm.ProductGroups = productGroupGenericManager.GetAll();
            vm.Products = productManager.GetProductsWithNavigations();
            vm.Currencies = currencyGenericManager.GetAll();
            vm.OrdersCurrencies = _orderCurrencyManager.GetOrdersCurrencies(id);
            vm.CurrentOrderId = id;
            if (orderProductId != null)
            {
                vm.OrderProduct = _orderProductsManager.GetById(orderProductId.Value);
            }
            else
            {
                vm.OrderProduct = new OrdersProduct();
            }

            return View(vm);
        }

        public async Task<string> AddOrdersProduct(OrdersProduct ordersProduct, string ProductName, string ProductBrandId, string ProductGroupId)
        {
            if (ordersProduct.ProductId == -1)
            {
                Product product = new Product();
                product.ProductName = ProductName;
                product.PorductBrandId = Convert.ToInt32(ProductBrandId);
                product.ProductGroupId = Convert.ToInt32(ProductGroupId);
                GenericManager<Product> productGenericManager =
                    new GenericManager<Product>(_userManager, new EfProductRepository());
                productGenericManager.Create(product);

            }
            
            //ordersProduct.ReferanceCode = $"{_user}"

            _orderProductsManager.Create(ordersProduct);


            return "OK";

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
    }
}
