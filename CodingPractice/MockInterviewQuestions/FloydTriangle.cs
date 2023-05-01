using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.MockInterviewQuestions
{
    // Write a method to print a floyd triangle on the console.
    // Bonus: do it again but wiht lists
    public class FloydTriangle
    {
        public void PrintFloyd(int number)
        {
            if (number <= 0)
            {
                Console.WriteLine("To print a Floyd Triangle, please enter an in greater than zero");
            }
            int counter = 1;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{counter} ");
                    counter++;
                }
            }
        }

        public List<List<int>> FloydList(int number)
        {
            List<List<int>> listToReturn = new List<List<int>>();
            if (number <= 0)
            {
                return listToReturn;
            }
            int counter = 1;
            for (int i = 1; i <= number; i++)
            {
                List<int> listToAdd = new List<int>();
                for (int j = 1; j <=i; j++)
                {
                    listToAdd.Add(counter);
                    counter++;
                }
                listToReturn.Add(listToAdd);
            }
            return listToReturn;
        }
    }
}
