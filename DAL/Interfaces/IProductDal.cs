using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL
{
    public interface IProductDal
    {
        void CreateProduct(Product productmodel);

        //update
        void UpdateProduct(Product productmodel);

        //get product
        Product GetProduct(int id);

        //get list product
        List<Product> GetAllproducts();

        //remove product
        void RemoveProduct(int id);
        
    }
}
