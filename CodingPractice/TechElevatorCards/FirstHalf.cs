using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TechElevatorCards
{
    public class FirstHalf
    {
        public string ReturnFirstHalf(string input)
        {
            return input.Substring(0, input.Length / 2);
        }
    }
}
