using GegiCRM.BLL.Abstract;
using GegiCRM.DAL.Abstract;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.BLL.Concrete
{
    public class AppAuthorizationRoleGroupManager : GenericManager<AppAuthorizationRoleGroup>
    {
        readonly IAppAuthorizationRoleGroupDal _appAuthorizationRoleGroupDal;

        public AppAuthorizationRoleGroupManager(UserManager<AppUser> userManager, IHttpContextAccessor httpContextAccessor, ILogger<AppAuthorizationRoleGroup> logger, IGenericDal<AppAuthorizationRoleGroup> genericDal) : base(userManager, httpContextAccessor, logger, genericDal)
        {
        }
    }
}
