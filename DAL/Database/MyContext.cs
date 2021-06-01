using DataModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database
{
    public class MyContext : DbContext, IDisposable
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Orders { get; set; }
        public DbSet<InvoiceLine> OrderLines { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }

        public MyContext(DbContextOptions<MyContext> Options) : base(Options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=mssql.fhict.local;Database=dbi419727_webshop;User Id=dbi419727_webshop;Password=test;");
        //}

       // protected override void OnModelCreating(ModelBuilder builder) => base.OnModelCreating(builder);
    }
}
