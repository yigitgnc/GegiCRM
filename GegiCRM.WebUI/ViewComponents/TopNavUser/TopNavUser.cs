using AutoMapper;
using GegiCRM.BLL.Concrete;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.ViewComponents.UserTopNav
{
    public class TopNavUser : ViewComponent
    {
        readonly AppUserManager _appUserManager;
        readonly AppIdentityRoleManager _roleManager;
        readonly IMapper _mapper;

        public TopNavUser(AppUserManager appUserManager, IMapper mapper)
        {
            _appUserManager = appUserManager;
            _mapper = mapper;
            _roleManager =  new AppIdentityRoleManager(appUserManager._userManager,new EfAppIdentityRoleRepository());
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _appUserManager._userManager.GetUserAsync(HttpContext.User);
            var model = _mapper.Map<TopNavUserDto>(user);
            var roles = await _appUserManager._userManager.GetRolesAsync(user);
            foreach (string item in roles)
            {
                model.UsersRoleGroups.Add(_roleManager.GetRoleGroupByRole(_roleManager.GetRoleByName(item)));
            }
            if (!model.UsersRoleGroups.Any())
            {
                model.UsersRoleGroups.Add(new AppIdentityRoleGroup { Name = "Rol Grubu Yok !"});
            }
            return View<TopNavUserDto>(model);
        }
    }
}
