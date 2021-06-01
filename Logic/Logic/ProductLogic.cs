using System;
using DataModel;
using DAL.Interfaces;
using DAL.Database;
using Logic.Interfaces;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace Logic
{
    public class ProductLogic
    {
        private readonly string _ErrorMessage = "Something went wrong";
        private readonly IProductDal _productDal;

        public ProductLogic( IProductDal productdal)
        {
            _productDal = productdal;
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
