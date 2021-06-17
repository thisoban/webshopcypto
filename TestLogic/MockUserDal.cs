using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DataModel;

namespace TestLogic
{
    public class MockUserDal : IUserDal
    {
        //private const string admin = "admin";
        private static  Role admin = new Role(){ Id=0, Name ="admin" };
        private static Role customer = new Role() { Id = 1, Name = "customer" };
        public List<User> _users = new List<User>()
        {
            new User()
            {
                Id = 0,
                Email="thisoban1995@hotmail.com",
                Firstname = "thisoban",
                Lastname = "mahalingam",
                Password = "tester",
                role = admin,
            },
            new User()
            {
                Id = 1,
                Email="customer@hotmail.com",
                Firstname = "customer",
                Lastname = "customer",
                Password = "customer",
                role = customer,
            },
            new User()
            {
                Id = 2,
                Email="customer2@hotmail.com",
                Firstname = "customer2",
                Lastname = "customer2",
                Password = "customer2",
                role = customer,
            },
        };
        
        public bool CreateUser(User user)
        {
            int count = _users.Count();
            _users.Add(user);
            if (count < _users.Count())
            {
                return true;
            }
            return false;
        }

        public User GetUserById(int userid)
        {
            User user = _users.Where(x => x.Id == userid).FirstOrDefault();
            return user;
        }

        public User GetUserByName(User user)
        {
            User getuser = _users.Where(x => x.Username == user.Username).FirstOrDefault();
            return getuser;
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
