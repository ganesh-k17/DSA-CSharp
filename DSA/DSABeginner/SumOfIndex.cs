using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{
    /*
     we need to get the indexes of sum of elements in the below list
    [12, 4, 5, 18, 5]

    example:
    targ = 23
    indexes = 2, 4

     */
    public class SumOfIndex
    {
        public static int[] Find(int targ, int[] input)
        {
            int sum = findSumOfNumber(targ);
            List<int> indexList = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == sum)
                {
                    indexList.Add(i);
                }
            }

            return indexList.ToArray();
        }

        static int findSumOfNumber(int targ)
        {
            int sum = 0;
            while (targ > 0)
            {
                int rem = targ % 10;
                sum = sum + rem;
                targ = targ / 10;
            }
            return sum;
        }
    }
}
