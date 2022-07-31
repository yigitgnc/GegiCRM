using GegiCRM.BLL.Concrete;
using GegiCRM.DAL.Concrete;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Hubs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GegiCRM.WebUI.ViewComponents.User
{
    public class GetAllUsers : ViewComponent
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppUserManager _appUserManager;

        public GetAllUsers(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
            _appUserManager = new AppUserManager(new EfAppUserRepository(), _signInManager);
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser user = await _appUserManager.GetCurrentUserAsync();

            CrmDbContext dbContext = new CrmDbContext();

            var data = dbContext.Users
                .Where(x => x.IsDeleted == false && x.Id != user.Id)
                .Include(x => x.UserActivityLogs)
                .OrderByDescending(x => x.IsOnline)
                .ToList();
            return View(data);
        }
    }
}