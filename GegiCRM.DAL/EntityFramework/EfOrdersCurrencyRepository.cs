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
    public class EfOrdersCurrencyRepository : GenericRepository<OrdersProductCurrency>, IOrdersProductCurrencyDal
    {
        public List<OrdersProductCurrency> GetListOrdersCurrencies(int orderProductId)
        {
            using Context context = new Context();
            return context.OrdersProductCurrencies.Where(x=>x.OrdersProductId == orderProductId && x.IsDeleted==false).Include(x=>x.Currency).ToList();
        }
    }
}
