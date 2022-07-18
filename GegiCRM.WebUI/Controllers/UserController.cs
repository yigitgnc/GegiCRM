using FluentValidation.Results;
using GegiCRM.BLL.Concrete;
using GegiCRM.BLL.ValidationRules;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Utils.CustomActionFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.Controllers
{

    [Authorize]
    [ActivityLogger]
    public class UserController : Controller
    {
        readonly AppUserManager _appUserManager;
        readonly UserManager<AppUser> userManager;

        public UserController(AppUserManager manager, UserManager<AppUser> userManager)
        {
            this._appUserManager = manager;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var data = _appUserManager.GetUsersWithAddedOrders();
            return View(data);
        }

        [HttpPost]
        public IActionResult AddUser(AppUser user)
        {
            UserValidator uw = new();
            ValidationResult result = uw.Validate(user);
            if (result.IsValid)
            {
                _appUserManager.Create(user);
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }


        public async Task<IActionResult> _GetAllUsers(){
            var data = _appUserManager.GetAll(false);
            return PartialView(data);
        }

        public async Task Test()
        {
            var user = _appUserManager.GetUserByEmail("yigit.genc@gegi.com.tr");
            var user2 = await userManager.FindByEmailAsync("yigit.genc.gegi.com.tr");
            var result = await _appUserManager._userManager.CreateAsync(user, "123321");
            if (result.Succeeded)
            {

            }
            var can = await _appUserManager._signInManager.CanSignInAsync(user);

            //return null;
        }


    }
}
