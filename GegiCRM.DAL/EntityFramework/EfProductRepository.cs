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
        public List<Product> GetProductsWithNavigations()
        {
            using var context = new Context();
            return context.Products
                .Include(x => x.Suppliers)
                .Include(x => x.ProductGroup)
                .Include(x => x.PorductBrand)
                .Include(x => x.AddedBy)
                .ToList();
        }

        public List<Product> GetProductsWithNavigationsByFilter(Expression<Func<Product, bool>> filter)
        {
            using var context = new Context();
            return context.Products
                .Where(filter)
                .Include(x => x.Suppliers)
                .Include(x => x.ProductGroup)
                .Include(x => x.PorductBrand)
                .Include(x => x.AddedBy)
                .ToList();
        }


        public Product? GetProductByIdWithNavigations(int id)
        {
            using var context = new Context();
            return context.Products
                .Where(x => x.Id == id)
                .Include(x => x.Suppliers)
                .Include(x => x.ProductGroup)
                .Include(x => x.PorductBrand)
                .Include(x => x.AddedBy)
                .FirstOrDefault();
        }

    }
}
