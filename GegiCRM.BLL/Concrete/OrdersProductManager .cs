using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GegiCRM.BLL.Generic;
using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace GegiCRM.BLL.Concrete
{
    public class OrdersProductManager : GenericManager<OrdersProduct>
    {
        readonly IOrdersProductDal _dal;
        private readonly AppUserManager _appUserManager;
        public readonly SignInManager<AppUser> _signInManager;

        public OrdersProductManager(IOrdersProductDal dal, SignInManager<AppUser> signInManager) : base(dal)
        {
            _appUserManager = new AppUserManager(new EfAppUserRepository(),signInManager);
            _dal = dal;
            _signInManager = signInManager;
        }

        public List<OrdersProduct> GetListByAllNavigations(int orderId)
        {
            return _dal.GetListByAllNavigations(orderId);
        }

        public string GenerateReferanceCode(AppUser user, ProductGroup productGroup)
        {
            string code = string.Empty;

            DateTime yearBegin = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime yearEnd = new DateTime(yearBegin.AddYears(1).Ticks);

            code = $"{user.NormalizedUserName}{DateTime.Now:yy}{productGroup.GroupName[0]}{_appUserManager.GetUsersGivenOrderCountByGroupId(productGroup.Id,user.Id,yearBegin,yearEnd).ToString("D5")}";

            return code;
        }
    }
}
