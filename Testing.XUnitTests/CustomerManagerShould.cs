using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace Testing.XUnitTests
{
    public class CustomerManagerShould
    {
        [Fact]
        public void CheckIfCustomerIsFromAthens()
        {
            var mock = new Mock<IDatabaseManager>();

            mock.Setup(m => m.FindCustomerById(10)).Returns(
                new Customer()
                {
                    Cid = 10,
                    FirstName = "test",
                    LastName = "test",
                    City = "Αθήνα"
                });

            mock.Setup(m => m.FindCustomerById(5)).Throws<DBConcurrencyException>();

            var customerManager = new CustomerManager(mock.Object);

            Assert.True(customerManager.IsFromAthens(10));
        }

        [Fact]
        public void ShouldHandleDatabaseExceptions()
        {
            var mock = new Mock<IDatabaseManager>();

            mock.Setup(m => m.FindCustomerById(5)).Throws<DBConcurrencyException>();

            var customerManager = new CustomerManager(mock.Object);

            Assert.False(customerManager.IsFromAthens(5));
        }
    }
}
