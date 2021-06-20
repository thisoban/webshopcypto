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
        private readonly IUserDal _context;
        // GET: ProductController
        public UserLogic(IUserDal userDal) => _context = userDal;
      
        //getuser
        public User GetUserById(int id)
        {
            return _context.GetUserById(id); 
        }
        public User GetUserByName(User user)
        {
            if (user.Username != null)
            {
                return _context.GetUserByName(user);
            }
            throw new ArgumentNullException("couldnt find user");
           
        }
       
        public bool CreateUser(User user)
        {
            if (_context.CreateUser(user) == false)
            {
                return true;
            }
            return false;
           
        }
        public void UpdateUser(User user)
        {
            User GetUser = _context.GetUserByName(user);
            if (GetUser != null)
            {
                if (_context.UpdateUser(user))
                {
                    throw new ArgumentException("succesful done");
                }
                throw new ArgumentException("something went wrong with updating");
            }
            throw new NullReferenceException(); ;
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
