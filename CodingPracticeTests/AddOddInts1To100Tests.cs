using CodingPractice.MockInterviewQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPracticeTests
{
    [TestClass]
    public class AddOddInts1To100Tests
    {
        [TestMethod]
        public void Expect2500()
        {
            // Arrange
            AddOddInts1To100 sut = new AddOddInts1To100();
            int expected = 2500;

            // Act
            int actual = sut.SumOfOddInts1To100();

            // Assert
            Assert.AreEqual(expected, actual);


        }
    }
}
