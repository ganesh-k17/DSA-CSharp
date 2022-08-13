using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{
    public class ReverseIntegerArray
    {
        public static int[] Calculate(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            int j = 0;
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                result[j] = numbers[i];
                j++;
            }
            return result;

            //// numbers = new int[] { 3, 2, 1, 8, 9 };
            //int[] result = new int[numbers.Length];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    result[i] = numbers[i];
            //    for (int j = i+1; j < numbers.Length; j++)
            //    {
            //        if (result[i] < numbers[j])
            //            result[i] = numbers[j];
            //    }
            //}
            //return result;
        }
    }
}
