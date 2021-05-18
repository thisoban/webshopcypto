using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataModel;
using DataModel.Enum;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IInvoiceDal
    {
        //get all invoices
        List<Invoice> GetAllinvoices();
        //get all invoices from one user
        List<Invoice> GetAllInvoicesFromOneUser(int userid);
        //get invoicedetails
        Invoice GetInvoiceDetails(int id);
        //updatestatus invoice
        bool UpdateInvoiceStatus(int id,Status status);
    }
}
