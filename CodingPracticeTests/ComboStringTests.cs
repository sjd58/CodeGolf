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
    public class ComboStringTests
    {
        [TestMethod]
        public void HappyPath()
        {
            // Arrange
            string testStringA = "Hi";
            string testStringB = "World";
            MakeComboStrings sut = new MakeComboStrings();
            string expected = "HiWorldHi";

            // Act
            string actual = sut.ComboString(testStringA, testStringB);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEmptyStrings()
        {
            // Arrange

            string testStringA = "";
            string testStringB = "Hi";
            MakeComboStrings sut = new MakeComboStrings();
            string expected = "Hi";

            // Act
            string actual = sut.ComboString(testStringA, testStringB);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
