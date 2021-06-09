using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Logic.Interfaces
{
    public interface ICustomerLogic
    {
         Customer GetCustomerDetail(int id);

         bool UpdateCustomerDetails(Customer customer, int id);

         bool removeCustomer(int id);
    }
}
