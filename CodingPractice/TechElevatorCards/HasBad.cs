using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TechElevatorCards
{
    public class HasBad
    {
        public bool HasBadInString(string input)
        {
            if (input.Length < 3)
            {
                return false;
            }
            if ((input[0] == 'b') && (input[1] == 'a') && (input[2] == 'd'))
            {
                return true;
            }
            if (input.Length == 3)
            {
                return false;
            }
            if ((input[1] == 'b') && (input[2] == 'a') && (input[3] == 'd'))
            {
                return true;
            }
            return false;
        }
    }
}
