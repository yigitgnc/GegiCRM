using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.Concrete;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.EntityFramework
{
    public class EfAppIdentityRoleRepository : GenericRepository<AppIdentityRole>, IAppIdentityRoleDal
    {
        public AppIdentityRole? GetRoleByName(string roleName)
        {
            using var c = new Context();
            return c.Set<AppIdentityRole>().FirstOrDefault(x => x.Name == roleName);
        }
        public AppIdentityRoleGroup? GetRoleGroupByRole(AppIdentityRole role)
        {
            using var c = new Context();
            return c.Set<AppIdentityRoleGroup>().Where(x => x.Id == role.Id).FirstOrDefault();
        }
    }
}
