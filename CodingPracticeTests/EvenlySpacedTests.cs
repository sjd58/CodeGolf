using CodingPractice;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingPractice.TechElevatorCards;

namespace CodingPracticeTests
{
    [TestClass]
    public class EvenlySpacedTests
    {
        [TestMethod]
        public void HappyPath()
        {
            // Arrange
            int[] testArray = new int[3] { 2, 4, 6 };
            EvenlySpaced sut = new EvenlySpaced();

            // Act
            bool actual = sut.IntsEvenlySpaced(testArray);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ReverseOrder()
        {
            // Arrange
            int[] testArray = new int[3] { 6, 4, 2 };
            EvenlySpaced sut = new EvenlySpaced();

            // Act
            bool actual = sut.IntsEvenlySpaced(testArray);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void MediumLargerThanLarge()
        {
            // Arrange
            int[] testArray = new int[3] { 2, 6, 4 };
            EvenlySpaced sut = new EvenlySpaced();

            // Act
            bool actual = sut.IntsEvenlySpaced(testArray);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckReturnsFalse()
        {
            // Arrange
            int[] testArray = new int[3] { 6, 2, 15 };
            EvenlySpaced sut = new EvenlySpaced();

            // Act
            bool actual = sut.IntsEvenlySpaced(testArray);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}
