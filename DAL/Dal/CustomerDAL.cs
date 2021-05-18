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
        private readonly MyContext _context;
        public CustomerDAL(MyContext context)
        {
            _context = context;
        }
        public Customer GetCustomer(int id)
        {
          return  _context.Customers
                    .Where(x => x.User.Id == id)
                    .FirstOrDefault();
        }

        public bool InsertCustomer(Customer customer)
        {
            bool created = false;
            try
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customer customer)
        {
            bool updated = false;
            try
            {
                _context.Customers.Update(customer);
                _context.SaveChanges();
                updated = true;
            }
            catch (Exception)
            {
                throw;
            }
            return updated;
        }
    }
}
