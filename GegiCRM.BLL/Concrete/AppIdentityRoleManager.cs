using GegiCRM.BLL.Abstract;
using GegiCRM.BLL.Generic;
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
    public class AppIdentityRoleManager : GenericManager<AppIdentityRole>
    {
        private readonly IAppIdentityRoleDal _appIdentityRoleDal;

        public AppIdentityRoleManager(IAppIdentityRoleDal appIdentityRoleDal) : base(appIdentityRoleDal)
        {
            _appIdentityRoleDal = appIdentityRoleDal;
        }
        public AppIdentityRole? GetRoleByName(string roleName)
        {
            return _appIdentityRoleDal.GetRoleByName(roleName);
        }
        public AppIdentityRoleGroup? GetRoleGroupByRole(AppIdentityRole role)
        {
            return _appIdentityRoleDal.GetRoleGroupByRole(role);
        }

    }
}
