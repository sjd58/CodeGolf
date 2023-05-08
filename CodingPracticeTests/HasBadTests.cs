using CodingPractice.TechElevatorCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPracticeTests
{
    [TestClass]
    public class HasBadTests
    {
        [TestMethod]
        public void HappyPath()
        {
            // Arrange
            HasBad sut = new HasBad();
            bool expected = true;
            string input = "abadaaaaa";

            // Act
            bool actual = sut.HasBadInString(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInputLengthThreeFalse()
        {
            // Arrange
            HasBad sut = new HasBad();
            bool expected = false;
            string input = "hey";

            // Act
            bool actual = sut.HasBadInString(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInputLengthLessThanThree()
        {
            // Arrange
            HasBad sut = new HasBad();
            bool expected = false;
            string input = "hi";

            // Act
            bool actual = sut.HasBadInString(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
