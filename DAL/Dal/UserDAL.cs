using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DAL.Database;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
   public class UserDAL : IUserDal
    {
        //getuser
        private readonly MyContext _context;
        public UserDAL(MyContext context)
        {
            _context = context;
        }
        public User GetUserById(int id)
        {
            User user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            return user;
             
        }
        public User GetUserByName(string name)
        {
            return _context.Users.Where(x => x.Username == name).FirstOrDefault();
        }
      
        //remove user
        public bool DeleteUser(int id)
        {
            bool Removed;
            try
            {
                var context = _context.Users.Where(x => x.Id == id)
                     .Include("Customer")
                     .Include("Invoice")
                     .Include("InvoiceLine")
                     .FirstOrDefault();
                Removed = true;
            }
            catch (Exception)
            {

                throw;
            }
            return Removed;
        }

        public void UpdateUser(User user, Customer customer)
        {
            var context = _context.Users.Where(x => x.Id == user.Id).Include("Customer").FirstOrDefault();

            context.Firstname = user.Firstname;
            context.Lastname = user.Lastname;
            context.Password = user.Password;
            context.Email = user.Email;
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        bool IUserDal.CreateUser(User user)
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
