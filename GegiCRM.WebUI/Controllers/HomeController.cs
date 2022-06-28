using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GegiCRM.BLL.Concrete;
using GegiCRM.DAL.Concrete;
using GegiCRM.DAL.EntityFramework;

namespace GegiCRM.WebUI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        Context context = new Context();
        private readonly AppUserManager _appUserManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly ILogger<HomeController> _logger;
        //private readonly ;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _appUserManager = new AppUserManager(new EfAppUserRepository(), signInManager);
        }
        public IActionResult Index()
        {
            var user = _appUserManager.GetCurrentUserAsync().GetAwaiter().GetResult(); 
            ViewBag.Currencies = context.Currencies.ToList();
            var activities = context.CustomerActivityLogs.Where(x => x.AddedById == user.Id).OrderByDescending(x => x.CreatedDate).ToList();
            return View(activities);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<int> GetUsersTotalTeklifCount(string type)
        {
            var user = await _appUserManager.GetCurrentUserAsync();
            var data = context.Orders.Where(x => x.AddedById == user.Id && x.IsDeleted == false).AsQueryable();

            if (type == "1")
            {
                data = data.Where(x => !x.IsOfferApproved);
            }
            else if (type == "2")
            {
                data = data.Where(x => x.IsOfferApproved);

            }

            return data.Count();
        }
    }
}