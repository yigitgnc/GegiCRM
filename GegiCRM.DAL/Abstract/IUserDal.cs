using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.Abstract
{
    public interface IUserDal:IGenericDal<User>
    {
        List<User> GetUsersWithAddedOrders();
        List<User> GetUsersWithModifiedOrders();
    }
}
