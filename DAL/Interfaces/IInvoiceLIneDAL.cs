using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL.Interfaces
{
    public interface IInvoiceLineDal
    {
        //TODO Getallinvoices
        List<InvoiceLine> GetAllInvoices(int id);
        //TODO insert invoicelines
        bool CreateInvoiceLines(List<InvoiceLine> invoicelines);
        //TODO get invoiceline from this order id
        InvoiceLine GetInvoiceline(int id);
        //TODO update invoiceline
        bool UpdateInvoiceline(InvoiceLine invoiceline);
        //TODO remove invoicline
        bool DeleteInvoiceline(InvoiceLine invoiceline);
    }
}
