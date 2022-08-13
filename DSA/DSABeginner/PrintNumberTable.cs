using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{
    // Print table of a number upt0 10
    public class PrintNumberTable
    {
        public static void Print(int n, int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine(n*i);
            }
        }
    }
}
