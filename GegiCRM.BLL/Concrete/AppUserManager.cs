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
        private readonly IAppUserDal _userDal;
        public readonly UserManager<AppUser> _userManager;
        public readonly SignInManager<AppUser> _signInManager;

        public AppUserManager(UserManager<AppUser> userManager, IAppUserDal userDal, SignInManager<AppUser> signInManager) : base(userManager, userDal)
        {
            _userDal = userDal;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        //todo: refactor these fucking public implementations these should be done in here not in controller using _appusermanager._signinmanager alike !

        //public AppUserManager(UserManager<AppUser> userManager, IHttpContextAccessor httpContextAccessor, IAppUserDal userDal, SignInManager<AppUser> signInManager, ILogger<AppUser> logger) : base(userManager, httpContextAccessor, logger)
        //{
        //    _userDal = userDal;
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //}

        public List<AppUser> GetUsersWithAddedOrders()
        {
            return _userDal.GetUsersWithAddedOrders();
        }

        public List<AppUser> GetUsersWithModifiedOrders()
        {
            return _userDal.GetUsersWithModifiedOrders();
        }

        public AppUser? GetUserByEmail(string email)
        {
            return _userDal.GetUserByEmail(email);
        }

    

        public string GenerateUserName(string name,string surname)
        {
            name = name.ToUpper();
            surname = surname.ToUpper();

            string userName = "";

            int tryCount = 0;
            int NameIndex = 0;
            int SurnameIndex = 0;

            do
            {
                try
                {
                    userName = $"{name.Substring(0, NameIndex)}{surname.Substring(0, SurnameIndex)}";
                    tryCount++;
                    if (tryCount % 2 == 0)
                    {
                        NameIndex++;
                    }
                    else
                    {
                        SurnameIndex++;
                    }

                }
                catch (Exception e)
                {
                    Random rnd = new Random();
                    userName = $"{name}{surname}{rnd.Next(int.MaxValue)}";
                }


            } while (ListByFilter(x => x.UserName == userName).Any());

            return userName;
        }

    }
}
