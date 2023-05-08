using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    public class MergeArrays
    {
        public string[] CombineStringArrays(string[] arrayOne, string[] arrayTwo)
        {
            string[] longerArray = arrayOne;
            string[] shorterArray = arrayTwo;
            int newArrayLength = arrayOne.Length + arrayTwo.Length;
            string[] arrayToReturn = new string[newArrayLength];
            int counter = 0;
            if (arrayTwo.Length > arrayOne.Length)
            {
                longerArray = arrayTwo;
                shorterArray = arrayOne;
            }
            for (int i = 0; i < shorterArray.Length; i++)
            {
                arrayToReturn[counter] = longerArray[i];
                counter++;
                arrayToReturn[counter] = shorterArray[i];
                counter++;
            }
            for (int i = shorterArray.Length; i < longerArray.Length; i++)
            {
                arrayToReturn[counter] = longerArray[i];
                counter++;
            }
            return arrayToReturn;
        }
    }
}
