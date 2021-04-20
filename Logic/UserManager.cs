using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace Logic
{
    public class UserManager
    {
        private readonly UserDAL _context;
        // GET: ProductController
        public UserManager()
        {
            _context = new UserDAL();
        }

        //getuser
        public User GetUserById(int id)
        {
            return _context.GetUserById(id); 
        }
        public User GetUserByName(string name)
        {
            return _context.GetUserByName(name);
        }
        //checkuser
        public bool CheckUser(string username, string password)
        {
            bool loggedIn = false;

            if (username != null && password !!= null)
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
        //remove user
        public bool DeleteUser(int id)
        {
            bool Removed = false;
            if(_context.DeleteUser(id)) Removed = true;
            return Removed;
        }

        public void UpdateUser(User user, Customer customer)
        {
          if(user != null && customer != null)
            {
                _context.UpdateUser(user, customer); 
            }

        }

        public void CreateUser(User user)
        {
            if (user != null)
            {
                _context.CreateUser(user);
            }
        }


    }
}
