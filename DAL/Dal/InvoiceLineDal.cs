using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DataModel;
using Microsoft.EntityFrameworkCore;
using DAL.Database;
using DAL.Interfaces;


namespace DAL.Dal
{
    public class InvoiceLineDal : IInvoiceLineDAL
    {
        private readonly MyContext _context;

        public InvoiceLineDal(MyContext context)
        {
            _context = context;
        }
        public bool CreateInvoiceLines(List<InvoiceLine> invoiceLines)
        {
            bool created = false;
            try
            {
                foreach (InvoiceLine invoice in invoiceLines)
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

        public List<InvoiceLine> GetAllInvoicelines(int id)
        {
           List<InvoiceLine> invoiceLines = new List<InvoiceLine>();

           try
           {
               invoiceLines = _context.OrderLines.Where(x => x.Order.Id == id).ToList();
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               throw;
           }

           return invoiceLines;
        }

    }
}
