using CodingPractice;

namespace CodingPracticeTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void HappyPath()
        {
            // Arrange
            int testInt = 4;
            FactorialChallenge sut = new FactorialChallenge();
            int expected = 24;

            // Act
            int actual = sut.returnFactorial(testInt);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}