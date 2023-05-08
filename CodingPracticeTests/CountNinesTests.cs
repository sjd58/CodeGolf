using CodingPractice.TechElevatorCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPracticeTests
{
    [TestClass]
    public class CountNinesTests
    {
        [TestMethod]
        public void HappyPath()
        {
            // Arrange
            CountNines sut = new CountNines();
            int[] input = new int[5] { 1, 2, 9, 9, 9 };
            int expected = 3;

            // Act
            int actual = sut.NumberOfNines(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NullInputTest()
        {
            // Arrange
            CountNines sut = new CountNines();
            int[] input = null;
            int expected = 0;

            // Act
            int actual = sut.NumberOfNines(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLengthZero()
        {
            // Arrange
            CountNines sut = new CountNines();
            int[] input = new int[0];
            int expected = 0;

            // Act
            int actual = sut.NumberOfNines(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
