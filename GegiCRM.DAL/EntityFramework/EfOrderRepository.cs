using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.Concrete;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GegiCRM.DAL.EntityFramework
{
    public class EfOrderRepository : GenericRepository<Order>, IOrderDal
    {
        public List<Order> GetListAllWithNavigations()
        {
            var context = new Context();
            var orders = context.Orders.Include(x => x.Customer).Include(x=>x.Customer.CustomerMainCompany).Include(x => x.Customer.CustomerRepresentetiveUsers).Include(x => x.OrdersProducts).ThenInclude(a => a.AddedByNavigation)
                .ToList();

            return orders;
        }
    }
}