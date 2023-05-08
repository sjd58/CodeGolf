using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TechElevatorCards
{
    public class SumOddsBetweenValues
    {
        public int SumOfOdds(int start, int end)
        {
            List<int> listOfOdds = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (!(i % 2 == 0))
                {
                    listOfOdds.Add(i);
                }
            }
            int sum = 0;
            foreach(int odd in listOfOdds)
            {
                sum += odd;
            }
            return sum;
        }
    }
}
