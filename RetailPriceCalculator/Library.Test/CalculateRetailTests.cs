using RetailPriceCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Library.Test
{
    public class CalculateRetailTests
    {
        [Fact]
        public void CalculateRetail()
        {
            //Arrange
            decimal expected = 10;
            //Act
            decimal actual = 4;//Calculate.CalculateRetail(5, 100);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
