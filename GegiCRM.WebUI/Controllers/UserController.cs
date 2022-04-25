using FluentValidation.Results;
using GegiCRM.BLL.Concrete;
using GegiCRM.BLL.ValidationRules;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.Controllers
{
    public class UserController : Controller
    {
        UserManager manager = new UserManager(new EfUserRepository());
        public IActionResult Index()
        {
            var data = manager.GetUsersWithAddedOrders();
            return View(data);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            UserValidator uw = new UserValidator();
            ValidationResult result = uw.Validate(user);
            if (result.IsValid)
            {
                manager.CreateUser(user);
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
