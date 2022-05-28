using GegiCRM.BLL.Concrete;
using GegiCRM.DAL.EntityFramework;
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
        TeklifTakipManager _teklifTakipManager;
        GenericManager<Customer> _customerManager;
        public TeklifTakipController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _teklifTakipManager = new TeklifTakipManager(userManager, new EfOrderRepository()); ;
            _customerManager = new GenericManager<Customer>(userManager, new EfCustomerRepository());
        }


        public IActionResult Index()
        {
            List<Order> model = _teklifTakipManager.GetAll();
            return View(model);
        }

        public IActionResult _NewOrderContentPartial()
        {
            ViewBag.Customers = _customerManager.GetAll();
            ViewBag.Users = _userManager.Users.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewOrder(string customer_Id, string rUser_Id)
        {
            var createdOrder = _teklifTakipManager.Create(customer_Id, rUser_Id);
            return RedirectToAction("TeklifOlustur", new { createdOrder.Id });
        }

        public IActionResult TeklifOlustur(int id)
        {
            return View();
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
