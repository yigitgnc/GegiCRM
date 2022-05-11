using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.Abstract
{
    public interface IAppUserDal : IGenericDal<AppUser>
    {
        List<AppUser> GetUsersWithAddedOrders();
        List<AppUser> GetUsersWithModifiedOrders();

        AppUser? GetUserByEmail(string email);
    }
}
