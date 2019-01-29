using System;
using System.Data;
using System.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.UnitTests
{
    [TestClass]
    public class CustomerManagerTests
    {
        [TestMethod]
        public void TestIsFromAthens()
        {
            var customerManager = new CustomerManager(new MonkeyDatabaseManager());

            Assert.IsTrue(customerManager.IsFromAthens(10));

            try
            {
                customerManager.IsFromAthens(5);
                Assert.Fail();
            }
            catch (DBConcurrencyException)
            {
            }

        }
    }
}
