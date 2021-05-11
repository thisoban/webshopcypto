using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DataModel;
using DataModel.Enum;

namespace DAL.Interfaces
{
    public interface IInvoiceDAL 
    {
        //TODO get all invoiceses
        List<Invoice> GetAllInvoices();
        //TODO get all invoices from one user
        List<Invoice> GetAllInvoicesFromOneUser();
        //TODO create invoice for user
        bool CreateInvoice(Invoice invoice);
        //TODO update invoice status
        bool UpdateInvoiceStatus(int id, Status status);
    }
}
