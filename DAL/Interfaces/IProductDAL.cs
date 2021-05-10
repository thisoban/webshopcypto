using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataModel;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProductDAL
    {
        bool CreateProduct(Product productmodel);

        //update
        bool UpdateProduct(Product productmodel);

        //get product
        Product GetProduct(int id);

        //get list product
        List<Product> GetAllproducts();

        //remove product
        bool DeleteProduct(int id);
    }
}
