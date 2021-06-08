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
        void CreateProduct(Product productmodel);
       
        //update
        void UpdateProduct(Product productmodel);

        //get product
        Product GetProduct(int id);

        //get list product
        List<Product> ListOfProducts();

        //remove product
        void RemoveProduct(int id);
    }
}
