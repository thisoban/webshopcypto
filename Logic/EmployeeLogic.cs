using DataModel;
using System;
using DAL.Database;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Dal;
using DAL.Interfaces;

namespace Logic
{
    public class EmployeeLogic : UserLogic
    {
        private readonly  IUserDAL _context;
       // public EmployeeLogic(MyContext context) => _context = new EmployeeDAL(context);
        public override bool CheckUser(string username, string password)
        {
            bool loggedIn = false;

            if (username != null && password != null)
            {
                try
                {
                    User user = _context.GetUserByName(username);
                    if (user.Username == username && user.Password == password) loggedIn = true;
                }
                catch (Exception)
                {
                    return loggedIn;
                }
            }
            return loggedIn;
        }

        public override void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public override void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
