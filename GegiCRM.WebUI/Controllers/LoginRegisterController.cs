using GegiCRM.DAL.EntityFramework;
using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginRegisterController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<User> _signInManager;

        public LoginRegisterController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        [Route("Login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel vm)
        {

            if (ModelState.IsValid)
            {
                BLL.Concrete.UserManager manager = new(new EfUserRepository());
                //todo burayı geriye doğru takip et 
                if (manager.getuserb)
                {

                }
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, 
                // set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(vm.Email,
                                   vm.Password, vm.RememberMe, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return RedirectToAction("Index","Home");
                }
                //we do not have 2factor authentication
                //if (result.RequiresTwoFactor)
                //{
                //    return RedirectToPage("./LoginWith2fa", new
                //    {
                //        RememberMe = Input.RememberMe
                //    });
                //}
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View();
                }
            }

            // If we got this far, something failed, redisplay form

            return RedirectToAction("Index", "Home");
        }



        public async Task<IActionResult> Logout()
        {
            //this is where the logout operations gonna go
            return RedirectToAction("Login");
        }

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("ForgotPassword")]
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
