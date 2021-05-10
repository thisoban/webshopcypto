using System;
using DataModel;
using Repository;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class ProductManager
    {
        private readonly string _ErrorMessage = "Something went wrong";
        private readonly ProductRepository _productDal;

        public ProductManager()
        {
            _productDal = new ProductRepository();
        }
        // create
        public bool CreateProduct(Product productmodel)
        {
            bool created = false;

            if (productmodel !=null &&_productDal.CreateProduct(productmodel)) created = true;
            return created;
        }
        //update
       public bool UpdateProduct(Product productmodel) => productmodel != null &&  !_productDal.UpdateProduct(productmodel) ;

        //get product
        public Product GetProduct(int id) => _productDal.GetProduct(id);

        //get list product
        public List<Product> ListOfProducts() => _productDal.GetAllproducts();

        //remove product
        public bool RemoveProduct(int id)
        {
            bool deleted = _productDal.RemoveProduct(id);
            return deleted;
        }
    }
}
