using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TechElevatorCards
{
    // Coding Exercise:
    // Create a string method called ComboString that takes in two strings "a" and "b".
    // Given 2 strings, a and b, return a string of the form short+long+short, with the
    // shorter string on the outside and the longer string on the inside. The strings
    // will not be the same length, but they may be empty (length 0).

    public class MakeComboStrings
    {
        public string ComboString(string a, string b)
        {
            string longerString = a;
            string shorterString = b;
            if (b.Length > a.Length)
            {
                longerString = b;
                shorterString = a;
            }
            return shorterString + longerString + shorterString;
        }
    }
}
