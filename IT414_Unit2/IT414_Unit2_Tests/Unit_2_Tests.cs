using System;
using IT414_Unit2;

namespace IT414_Unit2_Tests
{
    public class Unit_2_Tests
    {
        [Xunit.Fact]
        public void Unit_2_Tests()
        {
            // Arrange
            double expected = 10;

            //Act
            double actual = result.Equals(5, 5);

            //Assert
            Xunit.Assert.Equal(expected, actual);
        }
    }
}
