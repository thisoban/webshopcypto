using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interfaces;
using DataModel;

namespace Repository.Interfaces
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
    }
}
