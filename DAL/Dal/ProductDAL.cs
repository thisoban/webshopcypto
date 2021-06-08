using System;
using System.Collections.Generic;
using System.Linq;
using DataModel;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Database;
using DAL.Interfaces;

namespace DAL

{
    public class ProductDal : IProductDal
    {
        private readonly IMyContext _context;

        public ProductDal(IMyContext context)
        {
            _context = context;
        }
        
        public void CreateProduct(Product productmodel)
        {
            _context.Products.Add(productmodel);
            _context.SaveChanges();
        }
        //update
        public void UpdateProduct(Product productmodel)
        {
            _context.Products.Update(productmodel);
            _context.SaveChanges();
        }

        //get product
        public Product GetProduct(int id)
        {
            return   _context.Products
                    .Where(x => x.Id == id)
                    .FirstOrDefault();
        }

        //get list product
        public List<Product> GetAllproducts()
        {
            return _context.Products.ToList();
        }

        //remove product
        public void RemoveProduct(int id)
        {
            Product product = GetProduct(id);
            _context.Products.Remove(product);
        }
    }
}
