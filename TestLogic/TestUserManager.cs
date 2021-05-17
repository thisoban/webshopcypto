//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using DataModel;
//using Logic;
//using System.Threading.Tasks;

//namespace TestLogic
//{[TestClass]
//    public class TestUserManager
//    {
//        private readonly UserLogic _usermanager;
//        public TestUserManager()
//        {
//            _usermanager = new UserLogic();
//        }

//        [TestMethod]
//        public void UserLoginValid()
//        {
//           Assert.IsTrue( _usermanager.CheckUser("admin", "admin"));
//        }
//        [TestMethod]
//        public void UserLoginUnValid()
//        {
//            Assert.IsFalse(_usermanager.CheckUser("admin11", "admin"));
//        }
//        [TestMethod]
//        public void GetUserByIdValid()
//        {
//            Assert.IsNotNull(_usermanager.GetUserById(1));
//        }

//        [TestMethod]
//        public void GetUserByIdUnValid()
//        {
//            Assert.IsNull(_usermanager.GetUserById(200));
//        }
//        [TestMethod]
//        public void GetUserByUsernameValid()
//        {
//            //Assert.IsNotNull(_usermanager.GetUserByName("admin"));
//        }
//        public void GetUserByUsernameUnValid()
//        {
//            //Assert.IsNull(_usermanager.GetUserByName("tester"));
//        }

//    }
//}
