using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal SellPrice { get; set; }
        public decimal Buyprice { get; set; }
        public int Serialnumber { get; set; }
        public string ErrorMessage { get; set; }

        public ProductViewModel(DataModel.Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            Quantity = product.Quantity;
            SellPrice = product.SellPrice;
            Buyprice = product.Buyprice;
            Serialnumber = product.Serialnumber;
        }
        public ProductViewModel(string error)
        {
            ErrorMessage = error;
        }

        public ProductViewModel() { }

    }
}
