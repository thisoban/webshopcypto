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
    public class InvoiceDal :  IInvoiceDal
    {
        private readonly IMyContext _context;

        public InvoiceDal(IMyContext context)
        {
            _context = context;
        }
        public void CreateInvoice(Invoice invoice)
        {
            _context.Orders.Add(invoice);
            _context.SaveChanges();
        }

        public List<Invoice> GetAllinvoices()
        {
            return _context.Orders.ToList();
        }

        public List<Invoice> GetAllInvoicesFromOneUser(int userid)
        {
          return  _context.Orders.Where(x => x.Customer.User.Id == userid).ToList();
        }

        public Invoice GetInvoiceDetails(int id)
        {
            return _context.Orders.Include("OrderLine").Where(x => x.Id == id).FirstOrDefault();
        }

        public void UpdateInvoiceStatus(int id, OrderStatus status)
        {
            // do something first in logic to check if its there and then update if possible otherwise throw expection 
            Invoice invoice = GetInvoiceDetails(id);
            invoice.Status = status;
            _context.Orders.Update(invoice);
            _context.SaveChanges();
        }
    }
}
