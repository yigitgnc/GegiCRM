using FluentValidation.Results;
using GegiCRM.BLL.Concrete;
using GegiCRM.BLL.ValidationRules;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        readonly AppUserManager manager;

        public UserController(AppUserManager manager)
        {
            this.manager = manager;
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

        public IActionResult Test()
        {
            var data = manager.GetAll().FirstOrDefault();
            data.Name = data.Name;
            manager.Delete(data);

            return null;
        }
    }
}
