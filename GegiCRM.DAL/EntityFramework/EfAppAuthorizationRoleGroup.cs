using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.Concrete;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.EntityFramework
{
    public class EfAppAuthorizationRoleGroup : GenericRepository<AppAuthorizationRoleGroup>, IAppAuthorizationRoleGroupDal
    {
        public List<AppAuthorizationRoleGroup> GetUsersAuthorizationRolesByGroupID(int userId,int groupID)
        {
            return ListByFilter(x=>x.AddedBy == userId && x.Id == groupID);
        }


    }
}
