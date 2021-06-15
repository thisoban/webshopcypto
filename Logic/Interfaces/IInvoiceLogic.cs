using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Logic.Interfaces
{
   public interface IInvoiceLogic
    {
        List<Invoice> GetAllInvoices();
        List<Invoice> GetAllInvoicesFromUser(int userid);
        Invoice GetInvoice(int id);
        void CreateInvoice(Invoice invoice);
        void UpdateInvoice(Invoice invoice, int id);
        void RemoveInvoice(Invoice invoice, int id);
    }
}
