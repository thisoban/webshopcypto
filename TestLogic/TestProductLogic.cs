using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataModel;
using Logic;
using DAL;
using DAL.Database;
using System;

namespace TestLogic
{
    [TestClass]
    public class TestProductLogic
    {
        private readonly ProductLogic Logic = new ProductLogic(new MockProductDal());
        
        //TODO: maak productmanager createproduct checks of product exist op bepaalde properties van product
        [TestMethod]
        public void CreateProductSuccesful()
        {
            Product product = new Product() {
            Id = 4,
            Name = "test",
            Description ="testing",
            Quantity =101,
            SellPrice = 20,
            Buyprice = 10,
            Serialnumber = 112344};
            Logic.CreateProduct(product);
           
            Assert.IsNotNull(Logic.GetProduct(product.Id));
            Assert.AreEqual(product, Logic.GetProduct(product.Id));
        }
        [TestMethod]
        public void GetProductSuccesful()
        {
            Assert.IsNotNull(Logic.GetProduct(1));
            Assert.AreEqual(Logic.GetProduct(1), Logic.GetProduct(1));
        }
        [ExpectedException(typeof(ArgumentException),
             "something went wrong.")]
        [TestMethod]
        public void GetProductInvalid()
        {
            Assert.IsNull(Logic.GetProduct(5));
            Assert.AreEqual(Logic.GetProduct(6), Logic.GetProduct(6));
        }

        [TestMethod]
        public void UpdateProductValid()
        {
            Product oldproduct = Logic.GetProduct(3);
            Product product = new Product()
            {   Id= 3,
                Name = "tester",
                Serialnumber= 11234,
                SellPrice = 110000,
                Buyprice = 110000,
            };
            Logic.UpdateProduct(product);
               
            Assert.AreNotSame(oldproduct.Name, Logic.GetProduct(3).Name);
           
         //   Assert.IsTrue(Logic.UpdateProduct(product));
        }
        [TestMethod]
        public void UpdateProductUnValid()
        {
            Product product = new Product
            {
                Name = "tester",
                Serialnumber = 11234,
                SellPrice = 110000,
                Buyprice = 110000,
            };
            // Assert.IsTrue(Logic.UpdateProduct(product));
        }
    }
}
