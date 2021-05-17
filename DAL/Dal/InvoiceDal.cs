using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataModel;
using DAL.Interfaces;
using DAL.Database;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataModel.Enum;

namespace DAL
{
    public class InvoiceDal :  IInvoiceDAL
    {
        private readonly MyContext _context;

        public InvoiceDal( MyContext context)
        {
            _context = context;
        }
        public bool CreateInvoice(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetAllInvoices()
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetAllinvoices()
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetAllInvoicesFromOneUser()
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetAllInvoicesFromOneUser(int userid)
        {
            throw new NotImplementedException();
        }

        public Invoice GetInvoiceDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateInvoiceStatus(int id, Status status)
        {
            throw new NotImplementedException();
        }
    }
}
