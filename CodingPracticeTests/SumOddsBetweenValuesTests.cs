using CodingPractice.TechElevatorCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPracticeTests
{
    [TestClass]
    public class SumOddsBetweenValuesTests
    {
        [TestMethod]
        public void HappyPath()
        {
            // Act
            SumOddsBetweenValues sut = new SumOddsBetweenValues();
            int start = 0;
            int end = 100;
            int expected = 2500;

            // Arrange
            int actual = sut.SumOfOdds(start, end);


            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
