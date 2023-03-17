using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    public class FactorialChallenge
    {
        public int returnFactorial(int n)
        {
            int product = 1;
            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }
            return product;
        }
    }
}
