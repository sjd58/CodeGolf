using CodingPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPracticeTests
{
    [TestClass]
    public class MostFrequentCharTests
    {
        [TestMethod]
        public void HappyPath ()
        {
            // Arrange
            MostFrequentChar sut = new MostFrequentChar();
            string exampleString = "Hello there, hello hello!";
            char expected = 'l';

            // Act
            char actual = sut.ReturnMostFrequentChar(exampleString);
            
            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StringLengthOne()
        {
            // Arrange
            MostFrequentChar sut = new MostFrequentChar();
            string exampleString = "H";
            char expected = 'H';

            // Act
            char actual = sut.ReturnMostFrequentChar(exampleString);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
