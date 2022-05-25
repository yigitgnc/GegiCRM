using GegiCRM.BLL.Abstract;
using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.BLL.Concrete
{
    public class TeklifTakipManager : GenericManager<Order>
    {
        private readonly IOrderDal _orderDal;

        public TeklifTakipManager(UserManager<AppUser> userManager, IOrderDal orderDal) : base(userManager, orderDal)
        {
            _orderDal = orderDal;
        }

        public new Order Create(Order order)
        {
            order.OrderStateId = 5;
            base.Create(order);
            return order;
        }
        public new Order Create(string customerId, string rUserId)
        {
            Order order = new Order();
            order.RepresentetiveUserId = Convert.ToInt32(rUserId);
            order.CustomerId = Convert.ToInt32(customerId);
            order.OrderStateId = 5;
            base.Create(order);
            return order;
        }
    }
}
