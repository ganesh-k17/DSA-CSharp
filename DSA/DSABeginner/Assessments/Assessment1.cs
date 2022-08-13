using System;
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
            while (true)
            {
                int max = int.MaxValue;
                int min = int.MinValue;
                int theNUmber = -1;
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == -1)
                        continue;
                    if (numbers[i] > max)
                        max = numbers[i];
                    if (numbers[i] < min)
                        min = numbers[i];
                }
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] != -1)
                    {
                        theNUmber = numbers[i];
                        count++;
                    }
                    if (numbers[i] == max || numbers[i] == min)
                        numbers[i] = -1;                    
                }
                if(count == 1)
                {
                    return theNUmber;
                }
            }
        }
    }
}
