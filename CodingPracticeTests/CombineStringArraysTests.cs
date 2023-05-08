using CodingPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPracticeTests
{
    [TestClass]
    public class CombineStringArraysTests
    {
        [TestMethod]
        public void HappyPath()
        {
            // Arrange
            MergeArrays sut = new MergeArrays();
            string[] input1 = new string[9] { "hi", "hi", "hi", "hi", "hi", "hi", "hi", "hi", "hi" };
            string[] input2 = new string[5] { "yo", "yo", "yo", "yo", "yo" };
            string[] expected = new string[14] { "hi", "yo", "hi", "yo", "hi", "yo", "hi", "yo", "hi", "yo", "hi", "hi", "hi", "hi" };

            // Act
            string[] actual = sut.CombineStringArrays(input1, input2);

            // Assert
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
