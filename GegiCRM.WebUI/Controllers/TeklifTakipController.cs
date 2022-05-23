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
        TeklifTakipManager _teklifTakipManager;
        public TeklifTakipController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _teklifTakipManager = new TeklifTakipManager(userManager, new EfOrderRepository()); ;
        }


        public IActionResult Index()
        {
            List<Order> model = _teklifTakipManager.GetAll();
            return View(model);
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
