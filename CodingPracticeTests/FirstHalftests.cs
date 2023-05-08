using CodingPractice.TechElevatorCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPracticeTests
{
    [TestClass]
    public class FirstHalftests
    {
        [TestMethod]
        public void HappyPath()
        {
            // Arrange
            FirstHalf sut = new FirstHalf();
            string testtString = "aAABBb";
            string expected = "aAA";
            // Act
            string actual = sut.ReturnFirstHalf(testtString);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
