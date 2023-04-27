using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    public class EvenlySpaced
    {
        // Create a boolean method called EvenlySpaced that takes in
        // three integers, "a", "b", and "c"; given three ints, a, b, and c,
        // one of them is small, one is medium, and one is large. Return 
        // true if the three values are evenly spaced, so the difference
        // between small and medium is the same as the difference between 
        // the medium and large ints.
        // nums = [6, 4, 2]
        // nums = [4, 6, 2]
        // nums = [4, 2, 6]
        public bool IntsEvenlySpaced(int[] nums)
        {
            int placeholder = 0;
            int small = nums[0];
            int medium = nums[1];
            int large = nums[2];
            if (small > medium)
            {
                placeholder = small;
                small = medium;
                medium = placeholder;
            }
            if (medium > large)
            {
                placeholder = medium;
                medium = large;
                large = placeholder;
            }
            if (small > large)
            {
                placeholder = large;
                large = small;
                small = placeholder;
            }
            if (small > medium)
            {
                placeholder = small;
                small = medium;
                medium = placeholder;

            }

            int smallMediumSpace = medium - small;
            int mediumLargeSpace = large - medium;

            if (smallMediumSpace == mediumLargeSpace)
            {
                return true;
            }
            return false;
        }
    }
}
