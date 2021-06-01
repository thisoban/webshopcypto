using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataModel;
using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogic
{
    [TestClass]
    public class TestOrderManager
    {
      private readonly OrderLogic orderManager = new OrderLogic(new DAL.Database.MyContext());

        [TestMethod]
        public void  GetAllOrders()
        {
            Assert.IsNotNull(orderManager.GetAllOrders());
        }

        [TestMethod]
        public void GetAllOrdersFromOneAccount()
        {
            Assert.IsNotNull(orderManager.GetAllOrdersFromAccount(2));
        }
        [TestMethod]
        public void GetOrder()
        {
            Assert.IsNotNull(orderManager.GetOrder(4));
        }
    }
}
