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
    public class OrdersProductCurrencyManager: GenericManager<OrdersProductCurrency>
    {
        readonly IOrdersProductCurrencyDal _ordersProductCurrencyDal;

        public OrdersProductCurrencyManager(IOrdersProductCurrencyDal ordersProductCurrencyDal) : base(ordersProductCurrencyDal)
        {
            _ordersProductCurrencyDal = ordersProductCurrencyDal;
        }

        public List<OrdersProductCurrency> GetOrdersProductCurrencies(int orderID)
        {
            return _ordersProductCurrencyDal.GetListOrdersCurrencies(orderID);
        }
    }
}
