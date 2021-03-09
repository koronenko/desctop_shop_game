using Forma_Desctop_User;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject_1
{
    [TestClass]
    public class Form1Test
    {
        [TestMethod]
        public void WhenSetNullSetCredentialsChangedName()
        {
            User user = new User();
            Assert.IsNull(user.user_Shop);
            Assert.IsNull(user.user_Orders);
        }
    }
}
