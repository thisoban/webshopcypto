using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class InvoiceLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Sellprice { get; set; }
        public Invoice Order { get; set; }
        public Product Product { get; set; }
    }
}
