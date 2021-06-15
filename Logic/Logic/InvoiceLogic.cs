using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using Logic.Interfaces;
using DAL.Interfaces;

namespace Logic.Logic
{
    public class InvoiceLogic : IInvoiceLogic
    {
        private readonly IInvoiceDal _dal;
        public InvoiceLogic(IInvoiceDal Dal) => _dal = Dal;
        public void CreateInvoice(Invoice invoice)
        {
            if (invoice != null)
            {
                _dal.CreateInvoice(invoice);
            }
            else
            {
                throw new ArgumentException("missing some data to fill in the invoice");
            }
        }

        public List<Invoice> GetAllInvoices()
        {
            List<Invoice> invoices = _dal.GetAllinvoices();
            if (invoices!= null)
            {
                return invoices;
            }
            else
            {
                throw new ArgumentException("couldn't find any products");
            }
            
        }
        public List<Invoice> GetAllInvoicesFromUser(int userid)
        {
           return _dal.GetAllInvoicesFromOneUser(userid);
        }

        public Invoice GetInvoice(int id)
        {
            return _dal.GetInvoiceDetails(id);
        }

        public void RemoveInvoice(Invoice invoice, int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateInvoice(Invoice invoice, int id)
        {
            Invoice oldinvoice = _dal.GetInvoiceDetails(id);
            throw new NotImplementedException();
        }
    }
}
