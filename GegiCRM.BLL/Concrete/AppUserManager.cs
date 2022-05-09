using GegiCRM.BLL.Abstract;
using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.EntityFramework;
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
    public class AppUserManager : GenericManager<AppUser>
    {
        readonly IAppUserDal _userDal;

        public readonly SignInManager<AppUser> _signInManager;


        //todo: refactor these fucking public implementations these should be done in here not in controller using _appusermanager._signinmanager alike !

        public AppUserManager(UserManager<AppUser> userManager, IHttpContextAccessor httpContextAccessor, IAppUserDal userDal, SignInManager<AppUser> signInManager, ILogger<AppUser> logger) : base(userManager, httpContextAccessor, logger)
        {
            _userDal = userDal;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public override void Create(AppUser t)
        {
            t = SetAddedBy(t);
            _userDal.Insert(t);
        }

        public override void Delete(AppUser t)
        {
            t = SetLastModified(t);
            _userDal.Delete(t);
        }

        public override void Update(AppUser t)
        {
            t = SetLastModified(t);
            _userDal.Update(t);
        }

        public override List<AppUser> GetAll()
        {
            return _userDal.GetListAll();
        }

        public override AppUser GetById(int id)
        {
            return _userDal.GetByID(id);
        }

        public List<AppUser> GetUsersWithAddedOrders()
        {
            return _userDal.GetUsersWithAddedOrders();
        }

        public List<AppUser> GetUsersWithModifiedOrders()
        {
            return _userDal.GetUsersWithModifiedOrders();
        }

        public AppUser? GetUserByCredentials(string email, string passhash)
        {
            return _userDal.GetUserByLoginInformations(email, passhash);
        }

    }
}
