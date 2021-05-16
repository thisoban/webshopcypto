using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Logic.Interfaces
{
    public interface IProductLogic
    {
        public bool CreateProduct(Product productmodel);
       
        //update
        public bool UpdateProduct(Product productmodel);

        //get product
        public Product GetProduct(int id);

        //get list product
        public List<Product> ListOfProducts();

        //remove product
        public bool RemoveProduct(int id);
    }
}
