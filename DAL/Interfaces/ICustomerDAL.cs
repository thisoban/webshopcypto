using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL.Interfaces
{
    public interface ICustomerDal
    {
        //getcustomer
        Customer GetCustomer(int id);
        //insertcustomer
        void InsertCustomer(Customer customer);
        //updatecustomer
        void UpdateCustomer(Customer customer);
    }
}
