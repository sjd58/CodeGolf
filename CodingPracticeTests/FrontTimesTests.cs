using CodingPractice.TechElevatorCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPracticeTests
{
    [TestClass]
    public class FrontTimesTests
    {
        [TestMethod]
        public void HappyPath()
        {
            // Arrange
            FrontTimes sut = new FrontTimes();
            string input = "Chocolate";
            int times = 3;
            string expected = "ChoChoCho";

            // Act
            string actual = sut.FirstThreeCharsRepeated(input, times);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
