using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    public class MayvueExercises
    // Write a function called FindMinimum that accepts a list of integers 
    // and returns the minimum value of the list without sorting.If the passed list is empty or null return 0.
    {
        public int FindMinimum(List<int> input)
        {
            if (input == null || input.Count == 0)
            {
                return 0;
            }
            int intToReturn = input[0];
            foreach(int number in input)
            {
                if (number > intToReturn)
                {
                    intToReturn = number;
                }
            }
            return intToReturn;
        }
    }
}
