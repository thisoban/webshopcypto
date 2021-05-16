using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL.Interfaces
{
    public interface IUserDAL
    {
        bool CreateUser(User user);
        User GetUserById(int userid);
        bool UpdateUser(User user);
        User GetUserByName(User user);
    }
}
