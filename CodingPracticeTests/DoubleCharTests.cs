using CodingPractice.MockInterviewQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPracticeTests
{
    [TestClass]
    public class DoubleCharTests
    {
        [TestMethod]
        public void HappyPath()
        {
            // Act
            May1stMockInterview sut = new May1stMockInterview();
            string testString = "Thee";
            string expected = "TThheeee";

            // Arrange
            string actual = sut.doubleChar(testString);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
