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
        public override List<Order> GetListAll()
        {
            var context = new Context();
            var orders = context.Orders.Include(x => x.Customer.CustomerRepresentetiveUsers).Include(x => x.OrdersProducts).ThenInclude(a => a.AddedByNavigation)
                .ToList();

            return orders;
        }
    }
}