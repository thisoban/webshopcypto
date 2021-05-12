using DataModel;
using System;
using Repository.Database;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace Logic
{
    public class EmployeeManager : UserManager
    {
        private readonly UserRepository _context;
        public EmployeeManager() => _context = new UserRepository();
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
