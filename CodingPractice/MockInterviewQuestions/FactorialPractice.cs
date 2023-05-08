using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.MockInterviewQuestions
{
    public class FactorialPractice
    {
        // return a contains n terms in the fibonacci sequence
        public List<int> FibListNTerms(int n)
        {
            List<int> listToReturn = new List<int>();
            int a = 0;
            int b = 1;
            int c = 0;
            if (n <= 0)
            {
                return listToReturn;
            }
            listToReturn.Add(a);
            if (n == 1)
            {
                return listToReturn;
            }
            listToReturn.Add(b);
            for (int i = 2; i < n; i++)
            {
                c = b + a;
                listToReturn.Add(c);
                a = b;
                b = c;
            }
            return listToReturn;
        }

        // generate all the terms in the fibonacci sequence that are less than n
        public List<int> FibListUpToN(int n)
        {
            List<int> listToReturn = new List<int>();
            int a = 0;
            int b = 1;
            int c = 0;
            if (n > 0)
            {
                listToReturn.Add(a);
                if (n == 1)
                {
                    return listToReturn;
                }
                while (c < n)
                {
                    c = b + a;
                    listToReturn.Add(c);
                    a = b;
                    b = c;
                }
            }
            return listToReturn;
        }

        // print out the terms in the fib sequence that are less than n to the console.

        public void FibPrint(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            if (n <=0 )
            {
                Console.WriteLine("invalid input; input must be greater than or equal to 1");
            } else
            {
                Console.WriteLine("0");
                while (n > c)
                {
                    c = b + a;
                    Console.WriteLine(c);
                    a = b;
                    b = c;
                }
            }
        }
    }
}
