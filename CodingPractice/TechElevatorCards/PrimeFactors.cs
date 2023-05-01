using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TechElevatorCards
{
    public class PrimeFactors
    {
        public int[] ReturnPrimeFactors(int num)
        {
            List<int> primeFactorsList = new List<int>();

            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    primeFactorsList.Add(i);
                    num /= i;
                }
            }

            int[] arrayToReturn = new int[primeFactorsList.Count];
            for (int i = 0; i < primeFactorsList.Count; i++)
            {
                arrayToReturn[i] = primeFactorsList[i];
            }
            return arrayToReturn;
        }
    }
}
