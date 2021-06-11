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
        List<Product> products = new List<Product>();
        public void CreateProduct(Product productmodel)
        {
                products.Add(productmodel);
        }

        public List<Product> GetAllproducts()
        {
            List<Product> products = new List<Product>();
            Product product1 = new Product() {
                Id = 1,
                Description ="nice coin to have",
                Name = "bitcoin",
                SellPrice = 10000,
                Buyprice = 5000,
                Serialnumber = 123,
                Quantity = 3
            };
            Product product2 = new Product()
            {
                Id = 1,
                Description = "nice coin to have bought",
                Name = "litecoin",
                SellPrice = 13000,
                Buyprice = 3000,
                Serialnumber = 456,
                Quantity = 5
            };
            Product product3 = new Product()
            {
                Id = 1,
                Description = "coin that it sought after",
                Name = "thetacoin",
                SellPrice = 13000,
                Buyprice = 8000,
                Serialnumber = 789,
                Quantity = 5
            };
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            return products;
           
        }

        public Product GetProduct(int id)
        {

            Product product = new Product
            {
                Name = "tester",
                Serialnumber = 11234,
                SellPrice = 110000,
                Buyprice = 110000,
                Id = 5,
                Description = "test",
            };
            return product;
        }

        public void RemoveProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product productmodel)
        {
            if (productmodel.Id == 5)
            {
                
            }
            
        }
    }
}
