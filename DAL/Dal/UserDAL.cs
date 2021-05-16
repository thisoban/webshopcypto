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
        private readonly MyContext _context;
        public UserDAL(MyContext context)
        {
            _context = context;
        }
        public bool CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUserByName(User user)
        {
            throw new NotImplementedException();
        }
    }
}
