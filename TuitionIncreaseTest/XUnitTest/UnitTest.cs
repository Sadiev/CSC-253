using System;
using TuitionIncreaseTest;
using Xunit;

namespace XUnitTest
{
    public class UnitTest
    {
        [Theory]
        [InlineData(6000, 2, 6120)]
        [InlineData(6494.59, 2, 6624.48)]
        public void Test_Increase(decimal tuition, byte inc, decimal expected)
        {           
            //Arrange

            //Act
            decimal actual = Tuition.Increase(tuition, inc);
            //Assert
            Assert.Equal(expected.ToString("C"), actual.ToString("C"));
        }
    }
}
