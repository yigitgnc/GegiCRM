using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GegiCRM.BLL.Generic;
using GegiCRM.DAL.Abstract;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace GegiCRM.BLL.Concrete
{
    public class ProductManager : GenericManager<Product>
    {
        private readonly IProductDal _productDal;

        public ProductManager(UserManager<AppUser> userManager, IProductDal productDal) : base(userManager, productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetProductsWithNavigations(bool includeDeletedData)
        {
           return _productDal.GetProductsWithNavigations(includeDeletedData);
        }

        public List<Product> GetProductsWithNavigationsByFilter(Expression<Func<Product, bool>> filter, bool includeDeletedData)
        {
            return _productDal.GetProductsWithNavigationsByFilter(filter, includeDeletedData);
        }


        public Product? GetProductByIdWithNavigations(int id, bool includeDeletedData)
        {
            return _productDal.GetProductByIdWithNavigations(id, includeDeletedData);
        }
    }
}
