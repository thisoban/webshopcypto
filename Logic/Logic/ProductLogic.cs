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
    public class ProductLogic : IProductLogic
    {
        private readonly string _ErrorMessage = "Something went wrong";
        private readonly IProductDal _productDal;

        public ProductLogic(IProductDal productdal)
        {
            _productDal = productdal;
        }

        // create
        public void CreateProduct(Product productmodel)
        {   
            if (NotEmpty(productmodel))
            {
                _productDal.CreateProduct(productmodel);
            }
            else
            {
                throw new ArgumentException("product leeg is");
            }
            
        }
        //update
        public void UpdateProduct(Product productmodel)
        {
            if (productmodel != null)
            {
                if (NotEmpty(productmodel))
                {

                }
                _productDal.UpdateProduct(productmodel);
            }
            else
            {
                //custom exception worden
                throw new ArgumentException("productdetails missing");
            }
        } 

        //get product
        public Product GetProduct(int id) => _productDal.GetProduct(id);

        //get list product
        public List<Product> ListOfProducts() => _productDal.GetAllproducts();

        //remove product
        public void RemoveProduct(int id)
        {
            _productDal.RemoveProduct(id);
        }

        private bool NotEmpty(Product product)
        {
            if (product.Name != null && product.Serialnumber >= 0 && product.Description != null &&product.Buyprice >= 0 &&product.SellPrice >= 0 )
            {
                return true;
            }
                return false;
        }
    }
}
