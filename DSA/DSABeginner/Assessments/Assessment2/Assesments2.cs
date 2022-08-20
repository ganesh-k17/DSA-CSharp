using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner.Assessments
{
    public static class Assesments2
    {
        /*
         Q1: You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.

         A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.
                   
           Example 1:
           
           Input: accounts = [[1,2,3],[3,2,1]]
           Output: 6
           Explanation:
           1st customer has wealth = 1 + 2 + 3 = 6
           2nd customer has wealth = 3 + 2 + 1 = 6
           Both customers are considered the richest with a wealth of 6 each, so return 6.
           Example 2:
           
           Input: accounts = [[1,5],[7,3],[3,5]]
           Output: 10
           Explanation: 
           1st customer has wealth = 6
           2nd customer has wealth = 10 
           3rd customer has wealth = 8
           The 2nd customer is the richest with a wealth of 10.
           Example 3:
           
           Input: accounts = [[2,8,7],[7,1,3],[1,9,5]]
           Output: 17
        */

        //public static int WealthiestMansAmount(int[,] accounts) // 2D Array
        //{
        //    int max = 0;
        //    for (int i = 0; i < accounts.GetLength(0); i++)  // Row
        //    {
        //        int sum = 0;
        //        for (int j = 0; j < accounts.GetLength(1); j++)  // Column
        //        {
        //            sum = sum + accounts[i,j];
        //        }
        //        if (sum > max)
        //            max = sum;
        //    }
        //    return max;
        //}

        public static int WealthiestMansAmount(int[][] accounts)  // This one is worked in leetcode but not in IDE as the array initialize is throwing error.  The above one is working in IDE.
        {
            int max = 0;
            for (int i = 0; i < accounts.Length; i++)  // Row
            {
                int sum = 0;
                for (int j = 0; j < accounts[i].Length; j++)  // Column
                {
                    sum = sum + accounts[i][j];
                }
                if (sum > max)
                    max = sum;
            }
            return max;
        }

        /*
        Q2 Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

        Return the running sum of nums.
        
        Example 1:
        
        Input: nums = [1,2,3,4]
        Output: [1,3,6,10]
        Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
        Example 2:
        
        Input: nums = [1,1,1,1,1]
        Output: [1,2,3,4,5]
        Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
        Example 3:
        
        Input: nums = [3,1,2,10,1]
        Output: [3,4,6,16,17]
        */
        public static int[] SumOf1DArray(int[] numbers)
        {
            int[] sumNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < i + 1; j++)
                {
                    sum = sum + numbers[j];
                }
                sumNumbers[i] = sum;
            }
            return sumNumbers;
        }

        /* 
        Q3:  You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

        Letters are case sensitive, so "a" is considered a different type of stone from "A". 
        
        Example 1:
        
        Input: jewels = "aA", stones = "aAAbbbb"
        Output: 3
        Example 2:
        
        Input: jewels = "z", stones = "ZZ"
        Output: 0
        */
        /*
         1. arrange all the stones in a Dictionary 
         2. Find of the sum for jewels comparing in the dictionary (sum of jewels available in the dictionary).
        */
        public static int NumJewelsInStones(string jewels, string stones)
        {
            Dictionary<char, int> hash = new Dictionary<char, int>();
            for (int i = 0; i < stones.Length; i++)
            {
                int stone;
                if (hash.TryGetValue(stones[i], out stone))
                {
                    hash[stones[i]] = stone + 1;
                }
                else
                {
                    hash.Add(stones[i], 1);
                }
            }
            int sum = 0;
            for (int i = 0; i < jewels.Length; i++)
            {
                int stone;
                if (hash.TryGetValue(stones[i], out stone))
                {
                    sum = sum + stone;
                }
            }
            return sum;
        }

        /*
          Q4. Given an array of distinct integers arr, find all pairs of elements with the minimum absolute difference of any two elements.
          
          Return a list of pairs in ascending order(with respect to pairs), each pair [a, b] follows
          
          a, b are from arr
          a < b
          b - a equals to the minimum absolute difference of any two elements in arr
           
          
          Example 1:
          
          Input: arr = [4,2,1,3]
          Output: [[1,2],[2,3],[3,4]]
          Explanation: The minimum absolute difference is 1. List all pairs with difference equal to 1 in ascending order.
          Example 2:
          
          Input: arr = [1,3,6,10,15]
          Output: [[1,3]]
          Example 3:
          
          Input: arr = [3,8,-10,23,19,-4,-14,27]
          Output: [[-14,-10],[19,23],[23,27]]
           
          
          Constraints:
          
          2 <= arr.length <= 105
          -106 <= arr[i] <= 106
        */
        public static int[][] PairsWithMinDifferenceInAscOrder(int[] numbers)
        {
            Array.Sort(numbers);
            List<KeyValuePair<int, int[]>> list = new List<KeyValuePair<int, int[]>>();
            int[][] result = new int[numbers.Length/2][];
            for (int i = 0; i < numbers.Length-1; i++)
            {
                int[] pair = new int[] {numbers[i], numbers[i+1] };
                list.Add(new KeyValuePair<int, int[]>(Math.Abs(numbers[i] - numbers[i + 1]), pair));
            }
            IOrderedEnumerable< KeyValuePair<int, int[]>> ordered = list.OrderBy(l => l.Key);
            return ordered.Take(3).Select(l => l.Value).ToArray();
        }

        /*
          Q5. Given an integer array arr, return true if there are three consecutive odd numbers in the array. Otherwise, return false.
 
          
          Example 1:
          
          Input: arr = [2,6,4,1]
          Output: false
          Explanation: There are no three consecutive odds.
          Example 2:
          
          Input: arr = [1,2,34,3,4,5,7,23,12]
          Output: true
          Explanation: [5,7,23] are three consecutive odds.
           
          
          Constraints:
          
          1 <= arr.length <= 1000
          1 <= arr[i] <= 1000
          Accepted
          54,866
          Submissions
          85,921
        */
        public static bool ContainsThreeConsecutiveOdds(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    count = count + 1;
                else
                    count = 0;
                if (count == 3)
                    return true;
            }
            return false;
        }

        /*
          Q6. Given a 2D integer array matrix, return the transpose of matrix.

        The transpose of a matrix is the matrix flipped over its main diagonal, switching the matrix's row and column indices.
        
        Example 1:
        
        Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
        Output: [[1,4,7],[2,5,8],[3,6,9]]
        Example 2:
        
        Input: matrix = [[1,2,3],[4,5,6]]
        Output: [[1,4],[2,5],[3,6]]
         
        
        Constraints:
        
        m == matrix.length
        n == matrix[i].length
        1 <= m, n <= 1000
        1 <= m * n <= 105
        -109 <= matrix[i][j] <= 109
                */
        public static int[][] Transpose(int[][] matrix)
        {
            int[][] resultMatrix = new int[matrix[0].Length][];
            for (int i = 0; i < matrix[0].Length; i++)
            {
                int[] array = new int[matrix.Length];
                for (int j = 0; j < matrix.Length; j++)
                {
                    array[j] = matrix[j][i];
                }

                resultMatrix[i] = array;
            }
            return resultMatrix;
        }

        /*
          Given an array nums of size n, return the majority element.

          The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
            
          Example 1:
          
          Input: nums = [3,2,3]
          Output: 3
          Example 2:
          
          Input: nums = [2,2,1,1,1,2,2]
          Output: 2
           
          Constraints:
          
          n == nums.length
          1 <= n <= 5 * 104
          -109 <= nums[i] <= 109
 
        */
        //public static int MajorityElement(int[] nums)  // With double array
        //{
        //    int number = 0;
        //    int max = 0;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int times = 0;
        //        for (int j = 0; j < nums.Length; j++)
        //        {
        //            if (nums[i] == nums[j])
        //                times = times + 1;
        //        }
        //        if (times > max)
        //        {
        //            number = nums[i];
        //            max = times;
        //        }
        //    }
        //    return number;
        //}

        public static int MajorityElement(int[] nums)  // With single array
        {
            int number = 0;
            int result = 0;
            int max = 0;
            int count = 0;

            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != 0 && nums[i] != number)
                {
                    count = 0;
                    count = count + 1;
                }
                else
                {
                    count = count + 1;
                    if (count > max)
                    {
                        max = count;
                        result = nums[i];
                    }
                }

                number = nums[i];

            }
            return result;
        }

        /* 
         Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

         Note that you must do this in-place without making a copy of the array.

         Example 1:
         
         Input: nums = [0,1,0,3,12]
         Output: [1,3,12,0,0]
         Example 2:
         
         Input: nums = [0]
         Output: [0]
          
         
         Constraints:
         
         1 <= nums.length <= 104
         -231 <= nums[i] <= 231 - 1
          
         
         Follow up: Could you minimize the total number of operations done?
         Accepted
         1,836,077
         Submissions
         3,005,883 
        */

        public static int[] MoveZeroes(int[] nums)
        {
            int shift = 0;
            int n = nums.Length;
            int[] cloneNums = nums.ToArray();
            for (int i = 0; i < n; i++)
            {
                if(nums[i] == 0)
                {
                    for(; i < nums.Length-1; i++)
                    {
                        nums[i] = nums[i+1];
                    }

                    shift = shift + 1;
                    nums[(nums.Length) - shift] = 0;
                    i = -1;
                    n = n - 1;
                    continue;
                }
            }
            return nums;
        }
    }
}
