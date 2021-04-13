using System;
using DataModel;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class ProductManager
    {
        private MyContext _context;
        private readonly string _ErrorMessage = "Something went wrong";
        public ProductManager(MyContext context)
        {
            _context = context;
        }
        // create
        public string CreateProduct(Product productmodel)
        {
            string created = "product created";
            //check if created
            if (productmodel != null)
            {
                try
                {
                    _context.Products.Add(productmodel);
                    _context.SaveChanges();
                    
                }
                catch (Exception)
                {

                    throw new ArgumentException(_ErrorMessage, "couldn't create product");
                }
            }
           
            return created;
        }
        //update
        public bool UpdateProduct(Product productmodel)
        {
            bool updated = false;
            if (productmodel != null)
            {
                try
                {
                    _context.Products.Update(productmodel);
                    _context.SaveChanges();
                    updated = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return updated;
        }

        //get product
        public Product GetProduct(int id)
        {
            try
            {
                return _context.Products
                       .Where(x => x.Id == id)
                       .FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //get list product
        public List<Product> Getproducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                products = _context.Products.ToList();
                
            }
            catch (Exception e)
            {
               
                throw;
            }
            return products;
        }


        //remove product
        public bool RemoveProduct(int id)
        {
            bool deleted;
            try
            {
                Product product = GetProduct(id);
                _context.Products.Remove(product);
                deleted = true;

            }
            catch (ArgumentException e)
            {
           
                throw;
            }
            return deleted;
        }
    }
}
