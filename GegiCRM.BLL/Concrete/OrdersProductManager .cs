using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GegiCRM.DAL.Abstract;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace GegiCRM.BLL.Concrete
{
    public class OrdersProductManager: GenericManager<OrdersProduct>
    {
        readonly IOrdersProductDal _dal;

        public OrdersProductManager(UserManager<AppUser> userManager, IOrdersProductDal dal) : base(userManager, dal)
        {
            _dal = dal;
        }

        //public async Task<OrdersProduct> CreateOrdersProductWithReferanceCodeAsync(OrdersProduct order)
        //{
        //    order.ReferanceCode = await GenerateReferanceCode(order);
        //    order = base.Create(order);
        //    return order;
        //}

        //public async Task<string> GenerateReferanceCode(OrdersProduct order)
        //{
        //    string refCode = "";

        //    var claimsPrincipal = _httpContextAccessor.HttpContext?.User;
        //    var user = await _userManager.GetUserAsync(claimsPrincipal);
        //    if (user != null)
        //    {
        //        refCode = { }
        //    }

        //    return refCode;
        //}
    }
}
