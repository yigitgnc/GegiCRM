using GegiCRM.BLL.Generic;
using GegiCRM.DAL.Abstract;
using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.BLL.Concrete
{
    public class CustomerManager : GenericManager<Customer>
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal) : base(customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetListWithIncludes(params Expression<Func<Customer, object>>[] includes)
        {
            return _customerDal.Include(includes).ToList();
        }

    }
}
