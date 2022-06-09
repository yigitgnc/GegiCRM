using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.Concrete;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GegiCRM.DAL.EntityFramework
{
    public class EfOrderRepository : GenericRepository<Order>, IOrderDal
    {
        public List<Order> GetListAllWithNavigationsByFilter(Expression<Func<Order, bool>> filter)
        {
            var context = new Context();
            var orders = context.Orders
                .Where(x => !x.IsDeleted)
                .Where(filter)
                .Include(x => x.Customer)
                .Include(x => x.Customer.CustomerMainCompany)
                .Include(x => x.Customer.CustomerRepresentetiveUsers)
                .Include(x => x.OrdersProducts)
                .Include(x => x.AddedBy)
                .ToList();

            return orders;
        }

        public Order? GetByIdWithNavigations(int id)
        {
            var context = new Context();
            var order = context.Orders
                .Where(x => x.Id == id /*&& !x.IsDeneied*/)
                .Include(x => x.Customer)
                //.Include(x => x.Customer.CustomerMainCompany)
                .Include(x => x.Customer.CustomerRepresentetiveUsers)
                .Include(x => x.OrdersProducts)
                .Include(x => x.AddedBy)
                .FirstOrDefault();

            return order;
        }

        public List<Order> GetListAllWithNavigations()
        {
            var context = new Context();
            var orders = context.Orders.Where(x => !x.IsDeleted)
                .Include(x => x.Customer)
                .Include(x => x.Customer.CustomerMainCompany)
                .Include(x => x.Customer.CustomerRepresentetiveUsers)
                .Include(x => x.OrdersProducts)
                .Include(x => x.AddedBy)
                .ToList();

            return orders;
        }
    }
}