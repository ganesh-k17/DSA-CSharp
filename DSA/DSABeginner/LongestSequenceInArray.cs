using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{
    public static class LongestSequenceInArray

        // Asked in CISCO online test
    {
        // 1,2,3,4,5,7,8,9,10,11,12,13,14,15
        public static int FindLongestSequenceInArray(int[] numbers)
        {
            int result = 0; 
            int curResult = 1; // intitialize with 1 to have the count of number otherwise it would print the iteration count
            int i = 0;

            Array.Sort(numbers);
            for (i = 0; i < numbers.Length-1; i++)
            {
                int diff = numbers[i + 1] - numbers[i];
                if (diff == 0 || diff == 1)
                    curResult = curResult + 1;
                else
                {
                    if (curResult > result || i == numbers.Length - 2)
                        result = curResult; 
                    curResult = 1; // intitialize with 1 to have the count of number otherwise it would print the iteration count
                }
            }

            if(i== numbers.Length-1)
                result = curResult;

            return result;
        }
    }
}
