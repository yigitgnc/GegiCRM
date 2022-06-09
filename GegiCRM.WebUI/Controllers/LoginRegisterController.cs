using GegiCRM.BLL.Concrete;
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

        public readonly ILogger<HomeController> _logger;
        //private readonly SignInManager<AppUser> _signInManager;
        //private readonly UserManager<AppUser> _userManager;
        public readonly AppUserManager _appUserManager;

        public LoginRegisterController(AppUserManager appUserManager, ILogger<HomeController> logger)
        {
            _appUserManager = appUserManager;
            _logger = logger;
        }

        //public LoginRegisterController(SignInManager<AppUser> signInManager, ILogger<HomeController> logger, UserManager<AppUser> userManager)
        //{
        //    _signInManager = signInManager;
        //    _logger = logger;
        //    _userManager = userManager;
        //}


        [Route("Login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel vm, string? returnUrl)
        {

            if (ModelState.IsValid)
            {

                var user = await _appUserManager._userManager.FindByEmailAsync(vm.Email);
                if (user != null)
                {
                    var result = await _appUserManager._signInManager.PasswordSignInAsync(user, vm.Password, vm.RememberMe, lockoutOnFailure: true);

                    if (result.Succeeded)
                    {
                        _logger.LogInformation($"[{user}] logged in.");
                        if (Url.IsLocalUrl(returnUrl))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else if (result.IsLockedOut)
                    {
                        _logger.LogWarning($"[{user}] account locked out.");
                        return RedirectToPage("./Lockout");

                    }
                    else if (result.IsNotAllowed)
                    {

                        ModelState.AddModelError(string.Empty, "Hesap Aktif Değil !");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Hatalı Giriş Yaptınız !");
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Eksik Veya Hatalı Giriş Yaptınız !");
            }

            // If we got this far, something failed, redisplay form

            return View();
        }

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("Register")]
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserCompanyId = 1,
                    Email = vm.Email,
                    //UserName = vm.UserName,
                    Name = vm.Name,
                    Surname = vm.Surname,
                    PhoneNumber = vm.PhoneNumber,
                    AddedById = 1,

                };
              
                

                var result = await _appUserManager._userManager.CreateAsync(user, vm.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {

                        ViewData.ModelState.AddModelError(item.Code, item.Description);
                    }
                }

            }
            return View();
        }


        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            //this is where the logout operations gonna go
            AppUser user = await _appUserManager._userManager.GetUserAsync(User);
            await _appUserManager._signInManager.SignOutAsync();
            _logger.LogWarning($"[{user}] account logged out.");
            return RedirectToAction("Login");
        }

        [Route("ForgotPassword")]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        public async Task<string> Test()
        {
            return _appUserManager.GenerateUserName("Yiğit", "Genç");
        }
    }

}
