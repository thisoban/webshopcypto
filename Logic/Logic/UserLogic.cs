using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DAL.Database;
using DAL.Interfaces;
using Logic.Interfaces;
using Microsoft.EntityFrameworkCore;
using DAL;

namespace Logic
{
    public  class UserLogic : IUserLogic
    {
        private readonly IUserDAL _context;
        // GET: ProductController
        public UserLogic(MyContext context) => _context = new UserDAL(context);
      
        //getuser
        public User GetUserById(int id)
        {
            return _context.GetUserById(id); 
        }
        public User GetUserByName(User user)
        {
            return _context.GetUserByName(user);
        }
       
        public void CreateUser(User user)
        {
            
            if(_context.CreateUser(user) == false)
            {
                //return error message
            }
        }
        public void UpdateUser(User user)
        {
            if (_context.UpdateUser(user)) 
            {
                //return error message
            }
            //return true
            throw new NotImplementedException();
        }

        public bool CheckUserIsValid(string username, string password)
        {
            User user = new User() { Username = username, Password = password};

            User checkUser = _context.GetUserByName(user);
            if (checkUser != null)
            {
                if(checkUser.Username == user.Username && checkUser.Password == user.Password)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
