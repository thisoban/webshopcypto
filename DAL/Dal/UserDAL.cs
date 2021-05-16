using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Database;
using DataModel;


namespace DAL.Dal
{
    public class UserDAL : IUserDAL
    {
        private readonly IUserDAL _UserDAL;
        public UserDAL(MyContext context)
        {
            _UserDAL = new UserDAL(context);
        }
        public bool CreateUser(User user)
        {
           return _UserDAL.CreateUser(user);
        }
        public bool UpdateUser(User user)
        {
           return _UserDAL.UpdateUser(user);
        }
        public User GetUserByName(User user)
        {
            throw new NotImplementedException();
        }
        public User GetUserById(int userid)
        {
           return _UserDAL.GetUserById(userid);
        }
    }
}
