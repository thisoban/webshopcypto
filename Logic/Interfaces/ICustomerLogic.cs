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
        public Customer GetCustomerDetail(int id);

        public bool UpdateCustomerDetails(Customer customer, int id);

        public bool removeCustomer(int id);
    }
}
