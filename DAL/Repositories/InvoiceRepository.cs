using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataModel;
using Repository.Interfaces;
using Repository.Database;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        private readonly MyContext _context;
        public override Invoice GetEntity(Invoice entity)
        {
            Invoice invoice = _context.Orders
                      .Include("InvoiceLines")
                      .Include("Products")
                      .Where(x => x.Id == entity.Id)
                      .FirstOrDefault();                
            return invoice;
        }
    }
}
