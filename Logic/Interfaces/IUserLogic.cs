using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Logic.Interfaces
{
    public interface IUserLogic
    {
         User GetUserById(int id);
         User GetUserByName(User user);
          bool CheckUserIsValid(string username, string password);
          bool DeleteUser(int id);
          void UpdateUser(User user);
          bool CreateUser(User user);
    }
}
