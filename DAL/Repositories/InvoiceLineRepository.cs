using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interfaces;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Repository.Database;


namespace Repository.Repositories
{
    public class InvoiceLineRepository : Repository<InvoiceLine>,IInvoiceLineRepository
    {
        private readonly MyContext _context;
        public override InvoiceLine GetEntity(InvoiceLine entity)
        {
            return _context.OrderLines.Include("Products").Where( x => x.Id == entity.Id).FirstOrDefault();
        }
        
    }
}
