using GegiCRM.BLL.Abstract;
using GegiCRM.DAL.Abstract;
using GegiCRM.DAL.EntityFramework;
using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.BLL.Concrete
{
    public class UserManager : IGenericService<User>
    {
        readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Create(User t)
        {
            _userDal.Insert(t);
        }

        public void Delete(User t)
        {
            _userDal.Delete(t);
        }

        public void Update(User t)
        {
            _userDal.Update(t);
        }

        public List<User> GetAll()
        {
            return _userDal.GetListAll();
        }

        public User GetById(int id)
        {
            return _userDal.GetByID(id);
        }

        public List<User> GetUsersWithAddedOrders()
        {
            return _userDal.GetUsersWithAddedOrders();
        }

        public List<User> GetUsersWithModifiedOrders()
        {
            return _userDal.GetUsersWithModifiedOrders();
        }

        //public User? GetUserBy

    }
}
