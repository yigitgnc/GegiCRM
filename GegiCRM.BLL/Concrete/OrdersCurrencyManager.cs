using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GegiCRM.BLL.Generic;
using GegiCRM.DAL.Abstract;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace GegiCRM.BLL.Concrete
{
    public class OrdersCurrencyManager: GenericManager<OrdersCurrency>
    {
        readonly IOrdersCurrencyDal _ordersCurrencyDal;

        public OrdersCurrencyManager(UserManager<AppUser> userManager, IOrdersCurrencyDal ordersCurrencyDal) : base(userManager, ordersCurrencyDal)
        {
            _ordersCurrencyDal = ordersCurrencyDal;
        }

        public List<OrdersCurrency> GetOrdersCurrencies(int orderID)
        {
            return _ordersCurrencyDal.GetListOrdersCurrencies(orderID);
        }
    }
}
