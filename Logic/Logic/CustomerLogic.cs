using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DAL.Interfaces;
using Logic.Interfaces;

namespace Logic.Logic
{
    public class CustomerLogic : ICustomerLogic
    {
        private readonly ICustomerDal _dal;

        public CustomerLogic(ICustomerDal dal) => _dal = dal;
        
        public bool CreateCustomer(Customer customer)
        {
            _dal.InsertCustomer(customer);
            throw new NotImplementedException();
        }

        public Customer GetCustomerDetail(int id)
        {
            throw new NotImplementedException();
        }

        public bool removeCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomerDetails(Customer customer, int id)
        {
            throw new NotImplementedException();
        }
    }
}
