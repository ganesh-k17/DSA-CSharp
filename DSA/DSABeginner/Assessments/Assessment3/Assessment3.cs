using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner.Assessments.Assessment3
{
    public class Assessment3
    {
        /*
         Write an algorithm to determine if a number n is happy.

         A happy number is a number defined by the following process:
         
         Starting with any positive integer, replace the number by the sum of the squares of its digits.
         Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
         Those numbers for which this process ends in 1 are happy.
         Return true if n is a happy number, and false if not.
         
         Example 1:
         
         Input: n = 19
         Output: true
         Explanation:
         1² + 9² = 82
         8² + 2² = 68
         6² + 8² = 100
         1² + 0² + 0² = 1

         Example 2:
         
         Input: n = 2
         Output: false
         
         Constraints:
         
         1 <= n <= 231 - 1
         */
        public static bool IsHappyNumber(int number)
        {
            if (SquareSum(number) == 1)
                return true;
            return false;
        }

        static int SquareSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += (number % 10) * (number % 10);
                number = number / 10;
                if(number != 0)

            }
            return sum;
        }

    }
}
