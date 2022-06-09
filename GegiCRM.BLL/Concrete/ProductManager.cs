using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
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

        public List<Product> GetProductsWithNavigations()
        {
           return _productDal.GetProductsWithNavigations();
        }

        public List<Product> GetProductsWithNavigationsByFilter(Expression<Func<Product, bool>> filter)
        {
            return _productDal.GetProductsWithNavigationsByFilter(filter);
        }


        public Product? GetProductByIdWithNavigations(int id)
        {
            return _productDal.GetProductByIdWithNavigations(id);
        }
    }
}
