using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL.Interfaces
{
    public interface IUserDAL
    {
        bool CreateUser(User user);
        User GetUser(User user);
        bool UpdateUser(User user);
    }
}
