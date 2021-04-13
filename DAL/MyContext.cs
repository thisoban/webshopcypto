using DataModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyContext : DbContext, IDisposable
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Orders { get; set; }
        public DbSet<InvoiceLine> OrderLines { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        
        public MyContext(DbContextOptions options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder builder) => base.OnModelCreating(builder);


    }
}
