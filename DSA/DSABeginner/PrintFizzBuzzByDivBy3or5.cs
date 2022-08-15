using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{
    public class PrintFizzBuzzByDivBy3or5
    {
        public static string[] Print(int n)
        {
            string[] output = new string[n+1];

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    output[i-1] = "FizzBuzz";
                else if (i % 3 == 0)
                    output[i-1] = "Fizz";
                else if (i % 5 == 0)
                    output[i-1] = "Buzz";
                else
                    output[i-1] = i.ToString();
            }
            return output;
        }
    }
}
