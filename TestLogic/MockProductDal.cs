using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Interfaces;
using DataModel;

namespace TestLogic
{
    public class MockProductDal : IProductDal
    {

        List<Product> products = new List<Product>() {
              new Product() {
                Id = 1,
                Description ="nice coin to have",
                Name = "bitcoin",
                SellPrice = 10000,
                Buyprice = 5000,
                Serialnumber = 123,
                Quantity = 3
            },
        new Product()
        {
            Id = 2,
            Description = "nice coin to have bought",
            Name = "litecoin",
            SellPrice = 13000,
            Buyprice = 3000,
            Serialnumber = 456,
            Quantity = 5
         },
        new Product()
        {
            Id = 3,
            Description = "coin that it sought after",
            Name = "thetacoin",
            SellPrice = 13000,
            Buyprice = 8000,
            Serialnumber = 789,
            Quantity = 5
        }
       };
    
        public void CreateProduct(Product productmodel)
        {
           products.Add(productmodel);
        }

        public List<Product> GetAllproducts()
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            Product product = products.Where(x => x.Id == id).FirstOrDefault();
            return product;
        }

        public void RemoveProduct(int id)
        {
             Product product = products.Where(x => x.Id == id).FirstOrDefault();
            products.Remove(product);
        }
        public void UpdateProduct(Product productmodel)
        {
            Product oldproduct = products.SingleOrDefault(x => x.Id == productmodel.Id);
            if (oldproduct != null)
            {
                products.Remove(oldproduct);
                products.Add(productmodel);
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
