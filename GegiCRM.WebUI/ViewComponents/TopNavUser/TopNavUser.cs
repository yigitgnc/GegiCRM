using AutoMapper;
using GegiCRM.BLL.Concrete;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.ViewComponents.UserTopNav
{
    public class TopNavUser : ViewComponent
    {
        readonly AppUserManager _appUserManager; 
        readonly IMapper _mapper;
        readonly AppAuthorizationRoleGroupManager _authorizationRoleGroupManager;

        public TopNavUser(AppUserManager appUserManager, IMapper mapper)
        {
            _appUserManager = appUserManager;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _appUserManager._userManager.GetUserAsync(HttpContext.User);
            var model = _mapper.Map<TopNavUserDto>(user);
            //model.UsersRoleGroups = 
            return View(model);
        }
    }
}
