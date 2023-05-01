using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.MockInterviewQuestions
{
    public class MostCommonChar
    {
        public char MostUsedLetter(string input)
        {
            // Check if we get an invalid input
            if (input == null || input.Length == 0) throw new ArgumentNullException("input");
            // We will use a dictionary of unique 
            Dictionary<char, int> uniqueCharCounts = new Dictionary<char, int>();
            foreach (char c in input)
            {
                // check if the dictionary has this char. If not, add it as a key and start the value at 0.
                bool hasChar = false;
                foreach (KeyValuePair<char, int> item in uniqueCharCounts)
                {
                    if (c == item.Key)
                    {
                        hasChar = true;
                    }
                }
                if (!hasChar)
                {
                    uniqueCharCounts.Add(c, 0);
                }
            }
            // Count the frequency of the unique chars and add them to the values in the dicitonary.
            foreach (KeyValuePair<char, int> item in uniqueCharCounts)
            {
                int charCounter = 0;
                foreach (char c in input)
                {
                    if (item.Key == c)
                    {
                        charCounter++;
                    }
                }
                uniqueCharCounts[item.Key] = charCounter;
            }
            char charToReturn = 'a';
            int highestCharCount = 0;
            // find and return the Key that has the highest count
            foreach (KeyValuePair<char, int> item in uniqueCharCounts)
            {
                if(item.Value >= highestCharCount)
                {
                    highestCharCount = item.Value;
                    charToReturn = item.Key;
                }
            }
            return charToReturn;
        }
    }
}
