using RetailPriceCalculator;
using System;
using Xunit;

namespace XUnitTest
{
    public class UnitTest
    {
        [Fact]
        public void TestCalculateRetail()
        {
            //Arrange
            decimal expected = 10;
            //Act
            decimal actual = Calculate.CalculateRetail(5, 100);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
