using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interfaces;

namespace Repository
{
     public interface IProductRepository : IRepository<Product>
    {
        bool CreateProduct(Product productmodel);

        //update
        bool UpdateProduct(Product productmodel);

        //get product
        Product GetProduct(int id);

        //get list product
        List<Product> GetAllproducts();

        //remove product
        bool RemoveProduct(int id);
        
    }
}
