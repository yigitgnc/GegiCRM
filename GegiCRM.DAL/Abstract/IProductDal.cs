using GegiCRM.DAL.Abstract.Generic;
using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        public List<Product> GetProductsWithNavigations(bool includeDeletedData);
        public List<Product> GetProductsWithNavigationsByFilter(Expression<Func<Product, bool>> filter, bool includeDeletedData);
        public Product? GetProductByIdWithNavigations(int id, bool includeDeletedData);
    }
}
