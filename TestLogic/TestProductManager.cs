using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataModel;
using Logic;


namespace TestLogic
{
    [TestClass]
    public class TestProductManager
    {
        private readonly ProductManager productManager = new ProductManager();
        

        [TestMethod]
        public void CreateProductSuccesful()
        {
            Product product = new Product() { 
            Name = "test",
            Description ="testing",
            Quantity =101,
            SellPrice = 20,
            Buyprice = 10,
            Serialnumber =112344};
           Assert.IsTrue(productManager.CreateProduct(product));
           // ProductManager productManager = new ProductManager(_context).CreateProduct(product);
           
        }
        [TestMethod]
        public void GetProduct()
        {
            Assert.IsNotNull(productManager.GetProduct(1));
        }
        [TestMethod]
        public void GetProductInvalid()
        {
            Assert.IsNull(productManager.GetProduct(5));
        }

        [TestMethod]
        public void UpdateProductValid()
        {
            Product product = new Product
            {       Name = "tester",
                Serialnumber= 11234,
                SellPrice = 110000,
                Buyprice = 110000,
            };
            Assert.IsTrue(productManager.UpdateProduct(product));
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
            Assert.IsTrue(productManager.UpdateProduct(product));
        }
    }
}
