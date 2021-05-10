using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL.Interfaces
{
    public interface ICustomerDAL
    {
        //getcustomer
        Customer GetCustomer(int id);
        //instertcustomer
        bool InsertCustomer(Customer customer);
        //updatecustomer
        bool UpdateCustomer(Customer customer);
    }
}
