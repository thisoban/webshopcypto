using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL.Interfaces
{
    public interface IInvoiceLineDAL 
    {
        //get all from invoice
        List<InvoiceLine> GetAllInvoicelines(int id);
        //create invoiceline
        bool CreateInvoiceLines(List<InvoiceLine> invoiceLines);

    }
}
