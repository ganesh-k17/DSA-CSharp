using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{
    public class Find2Max
    {
        public static int[] Calculate(int[] numbers)
        {
            numbers = new int[] { 1,21,31,45,12,2,87,32 };
            int[] result = new int[2];
            result[0] = result[1] = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > result[0])
                {
                    result[1] = result[0];
                    result[0] = numbers[i];
                }
                else if (numbers[i] > result[1])
                    result[1] = numbers[i];
            }
            return result;
        }
    }
}
