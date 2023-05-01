using CodingPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingPractice.TechElevatorCards;

namespace CodingPracticeTests
{
    [TestClass]
    public class PrimeFactorsTests
    {
        [TestMethod]
        public void HappyPath()
        {
            // Arrange
            int testNumber = 12;
            PrimeFactors sut = new PrimeFactors();
            int[] expected = new int[3] { 2, 2, 3 };

            // Act
            int[] actual = sut.ReturnPrimeFactors(testNumber);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeNumber()
        {
            // Arrange
            int testNumber = 13;
            PrimeFactors sut = new PrimeFactors();
            int[] expected = new int[1] { 13 };

            // Act
            int[] actual = sut.ReturnPrimeFactors(testNumber);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ManyManyPrimes()
        {
            // Arrange
            int testNumber = 144;
            PrimeFactors sut = new PrimeFactors();
            int[] expected = new int[6] { 2, 2, 2, 2, 3, 3 };

            // Act
            int[] actual = sut.ReturnPrimeFactors(testNumber);

            // Assert
            CollectionAssert.AreEqual (expected, actual);
        }
    }
}
