using GegiCRM.BLL.Concrete;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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

        private GenericManager<Currency> _currencyManager;
        public TeklifTakipController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _teklifTakipManager = new TeklifTakipManager(userManager, new EfOrderRepository()); ;
            _customerManager = new GenericManager<Customer>(userManager, new EfCustomerRepository());
            _orderCurrencyManager = new OrdersCurrencyManager(_userManager, new EfOrdersCurrencyRepository());
            _currencyManager = new GenericManager<Currency>(_userManager, new EfCurrencieRepository());
            _orderStateManager = new GenericManager<OrderState>(_userManager, new GenericRepository<OrderState>());
        }


        public IActionResult Index()
        {
            List<Order> model = _teklifTakipManager.GetListAllWithNavigations();
            return View(model);
        }

        public IActionResult _NewOrderContentPartial()
        {
            ViewBag.Customers = _customerManager.ListByFilter(x=>x.IsDeleted == false);
            ViewBag.Users = _userManager.Users.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewOrder(string customer_Id, string rUser_Id)
        {
            var createdOrder = _teklifTakipManager.Create(customer_Id, rUser_Id);
            return RedirectToAction("Edit", new { createdOrder.Id });
        }

        public IActionResult Edit(int id)
        {
            var data = _teklifTakipManager.GetByIdWithNavigations(id);
            ViewBag.Customers = _customerManager.ListByFilter(x => x.IsDeleted == false);
            ViewBag.Users = _userManager.Users.Where(x=>x.IsDeleted == false).ToList();
            ViewBag.OrderStates = _orderStateManager.ListByFilter(x=>x.IsDeleted == false);
            return View(data);
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
          
            var orderC = _orderCurrencyManager.ListByFilter(x => x.Id ==id).FirstOrDefault();
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
