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
using CrmDbContext = GegiCRM.DAL.Concrete.CrmDbContext;

namespace GegiCRM.DAL.EntityFramework
{
    public class EfOrdersProductRepository : GenericRepository<OrdersProduct>, IOrdersProductDal
    {
        public List<OrdersProduct> GetListByAllNavigations(int orderId)
        {
            using CrmDbContext context = new CrmDbContext();
            return context.OrdersProducts
                .Where(x=> x.OrderId == orderId && !x.IsDeleted)
                .Include(x=>x.KesinSupplier)
                .Include(x=>x.ReferansSupplier)
                .Include(x=>x.KesinCurrency)
                .Include(x=>x.ReferansCurrency)
                .Include(x=>x.AddedBy)
                .Include(x=>x.ModifiedBy)
                .Include(x=>x.Birim)
                .Include(x=>x.Order)
                .Include(x=>x.Product)
                .Include(x=>x.Product.ProductGroup)
                .Include(x=>x.Product.PorductBrand)
                .Include(x=>x.KesinSevkDurumu)
                .ToList();
        }
    }
}
