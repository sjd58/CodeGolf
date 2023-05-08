using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TechElevatorCards
{
    public class FrontTimes
    {
        public string FirstThreeCharsRepeated(string input, int n)
        {
            if (input.Length <= 2)
            {
                return input;
            }
            string stringToRepeat = input.Substring(0, 3);
            string stringToReturn = "";
            for (int i = 0; i < n; i++)
            {
                stringToReturn += stringToRepeat;
            }
            return stringToReturn;
        }
    }
}
