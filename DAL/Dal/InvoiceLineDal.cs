using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DataModel;
using Microsoft.EntityFrameworkCore;
using DAL.Database;


namespace DAL.Dal
{
    public class InvoiceLineDal :IInvoiceLineDal
    {
        private readonly MyContext _context;

        public InvoiceLineDal(MyContext context)
        {
            _context = context;
        }

        public List<InvoiceLine> GetAllInvoices(int id)
        {
           List<InvoiceLine> invoiceLines = new List<InvoiceLine>();

           try
           {
               invoiceLines = _context.OrderLines
                    .Where(x => x.Order.Id == id)
                    .ToList();
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               throw;
           }

           return invoiceLines;
        }

        public InvoiceLine GetInvoiceline(int id)
        {
            InvoiceLine invoiceline;

            try
            {
              invoiceline = _context.OrderLines.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }

            return invoiceline;
        }

        public bool InsertInvoiceLines(List<InvoiceLine> invoicelines)
        {
            bool created = false;
            try
            {
                foreach (InvoiceLine invoice in invoicelines)
                {
                    _context.OrderLines.Add(invoice);
                }

                _context.SaveChanges();
                created = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return created;
        }

        public bool RemoveInvoiceLine(InvoiceLine invoiceline)
        {
            bool removed = false;
            try
            {
                _context.OrderLines.Remove(invoiceline);
                _context.SaveChanges();
                removed = true;
            }
            catch (Exception)
            {
                throw;
            }
            return removed;
        }

        public bool UpdateInvoiceline(InvoiceLine invoiceline)
        {
            bool updated = false;
            try
            {
                _context.OrderLines.Update(invoiceline);
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
