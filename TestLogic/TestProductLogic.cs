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
        public void CreateProductInvalid()
        {
            Product product = new Product()
            {
                Id = 5,
                Name = "test",
                Description = "yannick loopt keihard tegen de muur",
                Quantity = 10,
                Serialnumber = 1234564
            };

            Logic.CreateProduct(product);
            Product testpoduct = Logic.GetProduct(product.Id);


            Assert.IsNotNull(testpoduct);
            
        }
        [TestMethod]
        public void GetProductSuccesful()
        {
            // Arange
            Product product = new Product() 
            {
                Id = 3,
                Description = "coin that it sought after",
                Name = "thetacoin",
                SellPrice = 13000,
                Buyprice = 8000,
                Serialnumber = 789,
                Quantity = 5
            };
            // Act
            Product productToTest = Logic.GetProduct(3);

            // Assert
            Assert.IsNotNull(productToTest);
            Assert.Equals(product.Name, productToTest.Name);
           
        }
        //[ExpectedException(typeof(ArgumentException),
        //     "something went wrong.")]
        [TestMethod]
        public void GetProductInvalid()
        {
            Product product = Logic.GetProduct(5);
            Assert.IsNull(product);
        }

        [TestMethod]
        public void UpdateProductValid()
        {
            Product oldproduct = Logic.GetProduct(3);
            Product product = new Product()
            {   Id= 3,
                Name = "123",
                Serialnumber= 11234,
                SellPrice = 110000,
                Buyprice = 110000,
            };
            Logic.UpdateProduct(product);

            Product updatedproduct = Logic.GetProduct(3);
               
            Assert.IsTrue(oldproduct.Name == updatedproduct.Name);
           
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
