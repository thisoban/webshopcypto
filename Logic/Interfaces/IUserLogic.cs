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
        public abstract bool CheckUser(string username, string password);
        public abstract bool DeleteUser(int id);
        public abstract void UpdateUser(User user);
        public abstract void CreateUser(User user);
        
        
    }
}
