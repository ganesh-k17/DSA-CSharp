using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{
    public class PrintTriangleNumber
    {
        public static void Print()
        {
            int curr = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(curr++);
                    Console.Write(" ");
                }
                Console.WriteLine("\n");                
            }
        }
    }
}


/*
 
int current_line = 1;
        int element_printed = 0;
        for (int i = 1; i <= limit; i++) {
           System.out.print(i + " ");
            element_printed++;
           if (current_line == element_printed) {
                System.out.println();
                element_printed = 0;
                current_line++;

 */