using GegiCRM.DAL.Abstract.Generic;
using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.Abstract
{
    public interface IAppIdentityRoleDal : IGenericDal<AppIdentityRole>
    {
        public AppIdentityRole? GetRoleByName(string roleName);
        public AppIdentityRoleGroup? GetRoleGroupByRole(AppIdentityRole role);

        //public List<GetUsers>
        

        

    }
}
