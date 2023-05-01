using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TechElevatorCards
{

    // Given a string, return the char in the string that comes up most often in the string.
    public class MostFrequentChar
    {
        public char ReturnMostFrequentChar(string input)
        {
            List<char> charList = new List<char>();
            for(int i = 0; i < input.Length; i++)
            {
                bool hasChar = false;
                foreach(char c in charList)
                {
                    if (c == input[i])
                    {
                        hasChar = true;
                    }
                }
                if (hasChar == false)
                {
                    charList.Add(input[i]);
                }
            }
            int[] charCounts = new int[charList.Count];
            for (int i = 0; i < charList.Count;i++)
            {
                int charCount = 0;
                char c = charList[i];
                for(int j = 0; j < input.Length; j++)
                {
                    if (c == input[j])
                    {
                        charCount++;
                    }
                }
                charCounts[i] = charCount;
            }
            int greatestCharIndex = 0;
            int greatestCharCount = 0;
            for (int i = 0; i < charCounts.Length; i++)
            {
                if (charCounts[i] > greatestCharCount)
                {
                    greatestCharIndex = i;
                    greatestCharCount = charCounts[i];
                }
            }
            return charList[greatestCharIndex];
        }

        /*
         * TODO: do this method again, but using a dictionary.
        public char MostFrequentCharUsingDictionary(string input)
        {

        }
        */
    }
}
