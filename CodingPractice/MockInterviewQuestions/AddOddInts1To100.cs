using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.MockInterviewQuestions
{
    public class AddOddInts1To100
    {
        public int SumOfOddInts1To100()
        {
            int sum = 0;
            for (int i = 1; i <=100; i++)
            {
                if (!(i % 2 == 0))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
