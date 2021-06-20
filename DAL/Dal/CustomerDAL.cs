using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Database;
using DataModel;

namespace DAL.Dal
{
   public class CustomerDAL : ICustomerDal
    {
        private readonly IMyContext _context;
        public CustomerDAL(IMyContext context) => _context = context;
       
        public Customer GetCustomer(int id)
        {
          return  _context.Customers
                    
                    .Where(x => x.User.Id == id)
                    .FirstOrDefault();
        }

        public void InsertCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
    }
}
