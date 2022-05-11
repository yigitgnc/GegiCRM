using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.Concrete;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.EntityFramework
{
    public class EfUserRepository : GenericRepository<AppUser>, IAppUserDal
    {
        public AppUser? GetUserByEmail(string email)
        {
            using var c = new Context();
            return c.Users.FirstOrDefault(x => x.Email == email);
        }

        public AppUser? GetUserByEmail(string email, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetUsersWithAddedOrders()
        {
            using (Context c = new Context())
            {
                return c.Users.Include(x => x.OrderAddedByNavigations).ToList();
            }
            //Context c = new Context();
            //return c.Users.ToList();
        }

        public List<AppUser> GetUsersWithModifiedOrders()
        {
            throw new NotImplementedException();
        }
    }
}
