using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.BLL.Abstract
{
    public interface IUserService
    {
        void CreateUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
        List<User> GetAllUsers();
        User GetUserById(int id);

    }
}
