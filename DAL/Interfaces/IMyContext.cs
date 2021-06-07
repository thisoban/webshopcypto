using DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IMyContext :IDisposable
    {
         DbSet<User> Users { get; set; }
         DbSet<Customer> Customers { get; set; }
         DbSet<Invoice> Orders { get; set; }
         DbSet<InvoiceLine> OrderLines { get; set; }
         DbSet<Product> Products { get; set; }
         DbSet<Role> Roles { get; set; }
    }
}
