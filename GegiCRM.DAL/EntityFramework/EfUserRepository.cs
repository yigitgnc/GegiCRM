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
    public class EfUserRepository : GenericRepository<User>, IUserDal
    {
        public List<User> GetUsersWithAddedOrders()
        {
            using (Context c = new Context())
            {
                return c.Users.Include(x => x.OrderAddedByNavigations).ToList();
            }
            //Context c = new Context();
            //return c.Users.ToList();
        }

        public List<User> GetUsersWithModifiedOrders()
        {
            throw new NotImplementedException();
        }
    }
}
