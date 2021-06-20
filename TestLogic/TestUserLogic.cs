using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataModel;
using Logic;
using System.Threading.Tasks;

namespace TestLogic
{
    [TestClass]
    public class TestUserLogic
    {
        private readonly UserLogic _userLogic;
        public TestUserLogic()
        {
            _userLogic = new UserLogic(new MockUserDal());
        }

        [TestMethod]
        public void UserLoginValid()
        {
            Assert.IsTrue(_userLogic.CheckUserIsValid("admin", "admin"));
        }

        [TestMethod]
        public void UserLoginUnValid()
        {
            Assert.IsFalse(_userLogic.CheckUserIsValid("admin11", "admin"));
        }
        [TestMethod]
        public void GetUserByIdValid()
        {
            Assert.IsNotNull(_userLogic.GetUserById(1));
        }

        [TestMethod]
        public void GetUserByIdUnValid()
        {
            Assert.IsNull(_userLogic.GetUserById(200));
        }
        [TestMethod]
        public void GetUserByUsernameValid()
        {
            //Assert.IsNotNull(_usermanager.GetUserByName("admin"));
        }
        public void GetUserByUsernameUnValid()
        {
            //Assert.IsNull(_usermanager.GetUserByName("tester"));
        }

    }
}
