using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GegiCRM.DAL.Concrete;
using Microsoft.EntityFrameworkCore;

namespace GegiCRM.DAL.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductDal
    {
        public List<Product> GetProductsWithNavigations(bool includeDeletedRecords)
        {
            using var context = new Context();
            var data = context.Products
                .Include(x => x.Suppliers)
                .Include(x => x.ProductGroup)
                .Include(x => x.PorductBrand)
                .Include(x => x.AddedBy)
                .AsQueryable();

            if (!includeDeletedRecords)
            {
                data = data.Where(x => x.IsDeleted == false);
            }

            return data.ToList();
        }

        public List<Product> GetProductsWithNavigationsByFilter(Expression<Func<Product, bool>> filter, bool includeDeletedRecords)
        {
            using var context = new Context();
            var data = context.Products
                .Where(filter)
                .Include(x => x.Suppliers)
                .Include(x => x.ProductGroup)
                .Include(x => x.PorductBrand)
                .Include(x => x.AddedBy)
                .AsQueryable();

            if (!includeDeletedRecords)
            {
                data = data.Where(x => x.IsDeleted == false);
            }

            return data.ToList();
        }


        public Product? GetProductByIdWithNavigations(int id, bool includeDeletedRecords)
        {
            using var context = new Context();
            var data = context.Products
                .Where(x => x.Id == id)
                .Include(x => x.Suppliers)
                .Include(x => x.ProductGroup)
                .Include(x => x.PorductBrand)
                .Include(x => x.AddedBy).AsQueryable();

            if (!includeDeletedRecords)
            {
                data = data.Where(x => x.IsDeleted == false);
            }

            return data.FirstOrDefault();
        }

    }
}
