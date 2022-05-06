using GegiCRM.BLL.Concrete;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.ViewComponents.UserLayout
{
    public class UserTopNav : ViewComponent
    {
        readonly AppUserManager _appUserManager;

        public UserTopNav(AppUserManager appUserManager)
        {
            _appUserManager = appUserManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = User.Identity;

            return View(user);
        }
    }
}
