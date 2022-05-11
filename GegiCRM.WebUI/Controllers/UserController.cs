using FluentValidation.Results;
using GegiCRM.BLL.Concrete;
using GegiCRM.BLL.ValidationRules;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        readonly AppUserManager manager;
        readonly UserManager<AppUser> userManager;

        public UserController(AppUserManager manager, UserManager<AppUser> userManager)
        {
            this.manager = manager;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var data = manager.GetUsersWithAddedOrders();
            return View(data);
        }

        [HttpPost]
        public IActionResult AddUser(AppUser user)
        {
            UserValidator uw = new();
            ValidationResult result = uw.Validate(user);
            if (result.IsValid)
            {
                manager.Create(user);
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

        public async Task Test()
        {
            var user = manager.GetUserByEmail("yigit.genc@gegi.com.tr");
            var user2 = await userManager.FindByEmailAsync("yigit.genc.gegi.com.tr");
            var result = await manager._userManager.CreateAsync(user, "123321");
            if (result.Succeeded)
            {

            }
            var can = await manager._signInManager.CanSignInAsync(user);

            //return null;
        }
    }
}
