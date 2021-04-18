using System;
using System.Collections.Generic;
using System.Linq;
using DataModel;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ProductDAL 
    {
        private readonly MyContext _context;
        public ProductDAL()
        {
            _context = new MyContext();
        }
        public bool CreateProduct(Product productmodel)
        {
            bool created = false;
            //check if created
            if (productmodel != null)
            {
                try
                {
                    _context.Products.Add(productmodel);
                    _context.SaveChanges();
                    created = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return created;
        }
        //update
        public bool UpdateProduct(Product productmodel)
        {
            bool updated = false;
           
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
        public List<Product> GetAllproducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                products = _context.Products.ToList();

            }
            catch (Exception)
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
