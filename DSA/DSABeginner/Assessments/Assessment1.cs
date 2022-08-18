﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner.Assessment
{
    public class Assessment1
    {
        /*
         Q1. Given an array of N integers. Your task is to print the sum of all of the integers.
            Example 1:
            Input:
            4
            1 2 3 4
            Output:
            10
            Example 2:
            Input:
            6
            5 8 3 10 22 45
            Output:
            93          
        */
        public static int SumOfIntegers(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            return sum;
        }

        /*
         Q2. Given an array A[] of N integers and an index Key. Your task is to print the element present at
            index key in the array.
            Example 1:
            Input:
            5 2
            10 20 30 40 50
            Output:
            30
            Example 2:
            Input:
            7 4
            10 20 30 40 50 60 70
            Output:
            50     
        */
        public static int NumberAt(int index, int[] numbers)
        {
            return numbers[index];
        }

        /*
       Q3. Given an sorted array A of size N. Find number of elements which are less than or equal to given
            element X.
            Example 1:
            Input:
            N = 6
            A[] = {1, 2, 4, 5, 8, 10}
            X = 9
            Output:
            5
            Example 2:
            Input:
            N = 7
            A[] = {1, 2, 2, 2, 5, 7, 9}
            X = 2
            Output:
            4
        */
        public static int CountNumbersLessThan(int number, int[] numbers)
        {
            int count = 0;
            for(int i=0; i< numbers.Length; i++)
            {
                if (numbers[i] <= number)
                    count++;
            }
            return count;
        }

        /*
         Q4. You are given an array A of size N. You need to print elements of A in alternate order (starting
            from index 0).
            Example 1:
            Input:
            N = 4
            A[] = {1, 2, 3, 4}
            Output:
            1 3
            Example 2:
            Input:
            N = 5
            A[] = {1, 2, 3, 4, 5}
            Output:
            1 3 5
        */
        public static string PrintMeAlternateOrder(int[] numbers) 
        {
            string orderedNumber = string.Empty;
            for (int i = 0; i < numbers.Length; i=i+2)
            {
                orderedNumber += numbers[i] + " ";
            }
            return orderedNumber;
        }

        /*
        
        Q5. Given an array Arr of N positive integers. Your task is to find the elements whose value is equal
            to that of its index value ( Consider 1-based indexing ).
            Example 1:
            Input:
            N = 5
            Arr[] = {15, 2, 45, 12, 7}
            Output: 2
            Explanation: Only Arr[2] = 2 exists here.
            Example 2:
            Input:
            N = 1
            Arr[] = {1}
            Output: 1
            Explanation: Here Arr[1] = 1 exists.

        */
        public static int FindNumberAsIndex(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length; i++)
            {
                if (numbers[i] == i + 1)
                    return numbers[i];
            }
            return -1;
        }

        /*
         Q6. Given an array of size N and you have to tell whether the array is perfect or not. An array is said
         to be perfect if it's reverse array matches the original array. If the array is perfect then print
         "PERFECT" else print "NOT PERFECT".
         Example 1:
         Input : Arr[] = {1, 2, 3, 2, 1}
         Output : PERFECT
         Explanation:
         Here we can see we have [1, 2, 3, 2, 1]
         if we reverse it we can find [1, 2, 3, 2, 1]
         which is the same as before.
         So, the answer is PERFECT.
         Example 2:
         Input : Arr[] = {1, 2, 3, 4, 5}
         Output : NOT PERFECT
        */
        public static string IsPerfectArrayByReverse(int[] numbers)
        {
            int n = numbers.Length;
            int start = 0;
            int end = numbers.Length-1;
            for (int i = 0; i < n/2; i++)
            {
                if (numbers[start] != numbers[end])
                    return "NOT PERFECT";
                start += 1;
                end -= 1;
            }
            return "PERFECT";
        }

        /*
         Q7. Given an array of length N, at each step it is reduced by 1 element. In the first step the maximum
         element would be removed, while in the second step minimum element of the remaining array would
         be removed, in the third step again the maximum and so on. Continue this till the array contains only 1
         element. And find the final element remaining in the array.
         Example 1:
         Input:
         N = 7
         A[] = {7, 8, 3, 4, 2, 9, 5}
         Ouput:
         5
         Explanation:
         In first step '9' would be removed, in 2nd step
         '2' will be removed, in third step '8' will be
         removed and so on. So the last remaining
         element would be '5'.
         Example 2:
         Input:
         N = 8
         A[] = {8, 1, 2, 9, 4, 3, 7, 5}
         Ouput:
         4
        */
        public static int RemainingNumberAfterMaxMinRemoval(int[] numbers)
        {
            List<int> list = numbers.ToList();
            list.Sort();
            int length = list.Count;
            int remaining_number = list[ (length ^ 2) == 0 ? (length/2) - 1 : length / 2];
            return remaining_number;
        }

        /*
        Q8. Given an array of N distinct elements, the task is to find all elements in array except two greatest
        elements in sorted order.
        Example 1:
        Input :
        a[] = {2, 8, 7, 1, 5}
        Output :
        1 2 5
        Explanation :
        The output three elements have two or
        more greater elements.
        Example 2:
        Input :
        a[] = {7, -2, 3, 4, 9, -1}
        Output :
        -2 -1 3 4
       */

        public static int[] NumbersExpectTheLast2MaxNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers.ToList().SkipLast(2).ToArray();
        }

      /*
       Q9. Write a program to find the sum of the given series 1+2+3+ . . . . . .(N terms)
        Example 1:
        Input:
        N = 1
        Output: 1
        Explanation: For n = 1, sum will be 1.
        Example 2:
        Input:
        N = 5
        Output: 15
        Explanation: For n = 5, sum will be 1 + 2 + 3 + 4 + 5 = 15.

      */

        public static int SumOfIndividualNumbers(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        /*
         Q10. Given a number N. Your task is to check whether it is fascinating or not.
         Fascinating Number: When a number(should contain 3 digits or more) is multiplied by 2 and 3 ,and
         when both these products are concatenated with the original number, then it results in all digits from 1
         to 9 present exactly once.
         Example 1:
         Input:
         N = 192
         Output: Fascinating
         Explanation: After multiplication with 2
         and 3, and concatenating with original
         number, number will become 192384576
         which contains all digits from 1 to 9.
         Example 2:
         Input:
         N = 853
         Output: Not Fascinating
         Explanation: It's not a fascinating
         number. 
        */
        public static string IsFacinatingNumber(int n)
        {
            string expectedText = "1 2 3 4 5 6 7 8 9";
            string text = n.ToString();
            if (n.ToString().Length < 3)
                return "Not Fascinating";
            else
            {
                text = text + (n*2).ToString() + (n*3).ToString();
                char[] numbers = text.ToString().ToArray();
                Array.Sort(numbers);
                string resultText = string.Join(' ', numbers);
                return resultText.Equals(expectedText) ? "Fascinating" : "Not Fascinating";
            }
        }

        /*
        Given an array of even size N, task is to find minimum value that can be added to an element so that
        array become balanced. An array is balanced if the sum of the left half of the array elements is equal
        to the sum of right half.
        Example 1:
        Input:
        N = 4
        arr[] = {1, 5, 3, 2}
        Output: 1
        Explanation:
        Sum of first 2 elements is 1 + 5 = 6,
        Sum of last 2 elements is 3 + 2 = 5,
        To make the array balanced you can add 1.
        Example 2:
        Input:
        N = 6
        arr[] = { 1, 2, 1, 2, 1, 3 }
        Output: 2
        Explanation:
        Sum of first 3 elements is 1 + 2 + 1 = 4,
        Sum of last three elements is 2 + 1 + 3 = 6,
        To make the array balanced you can add 2.
       */

        public static int NumberToMakeThisBalanced(int[] n)
        {
            int firstHalfSum = n.SkipLast(n.Length / 2).Sum();
            int secondHalf = n.Skip(n.Length / 2).Sum();
            return Math.Abs(secondHalf - firstHalfSum);
        }
    }
}
