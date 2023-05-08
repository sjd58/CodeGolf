using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TechElevatorCards
{
    public class CountNines
    {
        public int NumberOfNines(int[] input)
        {
            int counter = 0;
            if (input == null || input.Length == 0)
            {
                return counter;
            }
            foreach(int number in input)
            {
                if (number == 9)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
