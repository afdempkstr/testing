using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testing.XUnitTests
{
    public class CalculatorShould
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, -1, 0)]
        [InlineData(0, 5, 5)]
        [InlineData(0.5, 0.5, 1)]
        public void AddNumbers(double x, double y, double expected)
        {
            var c = new Calculator();
            Assert.Equal(expected, c.Add(x, y));
        }

        [Fact]
        public void Moufa()
        {
            var c = new Calculator();
            Assert.IsType<Calculator>(c);
        }
    }
}
