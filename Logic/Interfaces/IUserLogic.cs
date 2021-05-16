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
        public User GetUserById(int id);
        public User GetUserByName(User user);
        public  bool CheckUserIsValid(string username, string password);
        public  bool DeleteUser(int id);
        public  void UpdateUser(User user);
        public  void CreateUser(User user);
        
        
    }
}
