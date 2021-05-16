using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Database;
using DataModel;

namespace DAL.Dal
{
    public class ProductDAL : IProductDAL
    {
        public MyContext _context;
        public ProductDAL(MyContext context)
        {
            _context = context;
        }
        public bool CreateProduct(Product productmodel)
        {
            bool Created = false;
            try
            {
                _context.Products.Add(productmodel);
                _context.SaveChanges();
                Created = true;
            }
            catch (Exception)
            {
                throw;
            }

            return Created;
        }

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllproducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product productmodel)
        {
            throw new NotImplementedException();
        }
    }
}
