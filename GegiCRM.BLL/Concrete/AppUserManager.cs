using GegiCRM.BLL.Abstract;
using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.BLL.Concrete
{
    public class AppUserManager : IGenericService<AppUser>
    {
        readonly IAppUserDal _userDal;

        public readonly UserManager<AppUser> _userManager;
        public readonly SignInManager<AppUser> _signInManager;
        //todo: refactor these fucking public implementations these hould be done in here not in controller using _appusermanager._signinmanager alike !

        public AppUserManager(UserManager<AppUser> userManager, IAppUserDal userDal, SignInManager<AppUser> signInManager)
        {
            _userDal = userDal;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public void Create(AppUser t)
        {
            _userDal.Insert(t);
        }

        public void Delete(AppUser t)
        {
            _userDal.Delete(t);
        }

        public void Update(AppUser t)
        {
            _userDal.Update(t);
        }

        public List<AppUser> GetAll()
        {
            return _userDal.GetListAll();
        }

        public AppUser GetById(int id)
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
