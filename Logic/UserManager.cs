using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using Repository;
using Microsoft.EntityFrameworkCore;

namespace Logic
{
    public abstract class UserManager
    {
        private readonly UserRepository _context;
        // GET: ProductController
        public UserManager() => _context = new UserRepository();
      

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
        public abstract bool CheckUser(string username, string password);
        //{
        //    //bool loggedIn = false;

        //    //if (username != null && password != null)
        //    //{
        //    //    try
        //    //    {
        //    //        User user = _context.GetUserByName(username);
        //    //        if (user.Username == username && user.Password == password) loggedIn = true;
        //    //    }
        //    //    catch (Exception)
        //    //    {
        //    //        return loggedIn;
        //    //    } 
        //    //}

        //    //return loggedIn;
        //}
        //remove user
        public abstract bool DeleteUser(int id);
        //{
        //    bool Removed = false;
        //    if(_context.DeleteUser(id)) Removed = true;
        //    return Removed;
        //}

        public abstract void UpdateUser(User user);
        //{
        //  if(user != null && customer != null)
        //    {
        //        _context.UpdateUser(user, customer); 
        //    }
        //}

        public abstract void CreateUser(User user);
        //{
        //    if (user != null)
        //    {
        //        _context.CreateUser(user);
        //    }
        //}


    }
}
