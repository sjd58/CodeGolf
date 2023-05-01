using CodingPractice.MockInterviewQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CodingPracticeTests
{
    [TestClass]
    public class MostCommonCharTests
    {
        [TestMethod]
        public void HappyPath()
        {
            // Arrange
            MostCommonChar sut = new MostCommonChar();
            string testString = "Hello world! Hello hello hello!";
            char expected = 'l';

            // Act
            char actual = sut.MostUsedLetter(testString);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void HappyPath2()
        {
            // Arrange
            MostCommonChar sut = new MostCommonChar();
            string testString = "Yooooooooooooooo what's up?";
            char expected = 'o';

            // Act
            char actual = sut.MostUsedLetter(testString);

            // Assert
            Assert.AreEqual(expected , actual);
        }

        [TestMethod]
        // Assert
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullString()
        {
            // Arrange
            MostCommonChar sut = new MostCommonChar();
            string testString = null;

            // Act
            sut.MostUsedLetter(testString);
        }

        [TestMethod]
        // Assert
        [ExpectedException (typeof(ArgumentNullException))]
        public void TestEmptyString()
        {
            // Arrange
            MostCommonChar sut = new MostCommonChar();
            string testString = "";

            // Act
            sut.MostUsedLetter(testString);
        }
    }
}
