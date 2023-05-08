using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.MockInterviewQuestions
{
    public class May1stMockInterview
    {
        // Double char
        // Given a string, return a string where every char in the original string is double.
        // doubleChar("The") → "TThhee"
        //doubleChar("AAbb") → "AAAAbbbb"
        //doubleChar("Hi-There") → "HHii--TThheerree"
        public string doubleChar(string str)
        {
            if (str == null || str.Length ==0)
            {
                return "";
            }
            string stringToReturn = "";
            foreach(char c in str)
            {
                stringToReturn += c;
                stringToReturn += c;
            }
            return stringToReturn;
        }
    }
}
