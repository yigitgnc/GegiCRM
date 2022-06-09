using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.Abstract
{
    public interface IOrderDal : IGenericDal<Order>
    {
        public List<Order> GetListAllWithNavigations();
        public List<Order> GetListAllWithNavigationsByFilter(Expression<Func<Order, bool>> filter);
        public Order? GetByIdWithNavigations(int id);
        
    }
}
