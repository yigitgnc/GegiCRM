using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GegiCRM.DAL.Concrete;
using Microsoft.EntityFrameworkCore;

namespace GegiCRM.DAL.EntityFramework
{
    public class EfOrdersCurrencyRepository : GenericRepository<OrdersCurrency>, IOrdersCurrencyDal
    {
        public List<OrdersCurrency> GetListOrdersCurrencies(int orderProductId)
        {
            using CrmDbContext context = new CrmDbContext();
            return context.OrdersCurrencies.Where(x=>x.OrderId == orderProductId && x.IsDeleted==false).Include(x=>x.Currency).ToList();
        }
    }
}
