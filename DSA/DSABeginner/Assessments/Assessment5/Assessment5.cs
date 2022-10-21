using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner.Assessments.Assessment5
{
    public static class Assessment5
    {
        /*
         1.
         https://leetcode.com/problems/two-sum/
        
         Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        
        You can return the answer in any order.
        
        Example 1:
        
        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        Example 2:
        
        Input: nums = [3,2,4], target = 6
        Output: [1,2]
        Example 3:
        
        Input: nums = [3,3], target = 6
        Output: [0,1]
         
        Constraints:
        
        2 <= nums.length <= 104
        -109 <= nums[i] <= 109
        -109 <= target <= 109
        Only one valid answer exists.

        */
        public static int[] TwoSum(int[] nums, int target)
        {
            int length = nums.Length;
            Dictionary<int, int> hm = new Dictionary<int, int>();

            for (int i = 0; i < length; i++)
            {
                if (hm.ContainsKey(target - nums[i]))
                    return new int[] { hm[target - nums[i]], i };
                else if (!hm.ContainsKey(nums[i]))
                    hm.Add(nums[i], i);
            }

            return Array.Empty<int>(); // new int[] { };
        }

        /*
        2.
         https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/

        Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.

        Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.
        
        The tests are generated such that there is exactly one solution. You may not use the same element twice.
        
        Your solution must use only constant extra space.
        
        Example 1:
        
        Input: numbers = [2,7,11,15], target = 9
        Output: [1,2]
        Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].
        Example 2:
        
        Input: numbers = [2,3,4], target = 6
        Output: [1,3]
        Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3. We return [1, 3].
        Example 3:
        
        Input: numbers = [-1,0], target = -1
        Output: [1,2]
        Explanation: The sum of -1 and 0 is -1. Therefore index1 = 1, index2 = 2. We return [1, 2].
         
        
        Constraints:
        
        2 <= numbers.length <= 3 * 104
        -1000 <= numbers[i] <= 1000
        numbers is sorted in non-decreasing order.
        -1000 <= target <= 1000
        The tests are generated such that there is exactly one solution.
        */
        public static int[] TwoSumII(int[] numbers, int target)
        {
            /*
            int length = numbers.Length;
            Dictionary<int, int> hm = new Dictionary<int, int>();

            for (int i = 0; i < length; i++)
            {
                if (hm.ContainsKey(target - numbers[i]))
                    return new int[] { hm[target - numbers[i]], i };
                else if (!hm.ContainsKey(numbers[i]))
                    hm.Add(numbers[i], i);
            }

            return Array.Empty<int>(); // new int[] { };
            */

            /* Two pointer approach! */

            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if ((numbers[left] + numbers[right]) < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return Array.Empty<int>();
        }

        /*
         3.
         https://leetcode.com/problems/merge-sorted-array/ 

        You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

        Merge nums1 and nums2 into a single array sorted in non-decreasing order.
        
        The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
        
        Example 1:
        
        Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        Output: [1,2,2,3,5,6]
        Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
        The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
        Example 2:
        
        Input: nums1 = [1], m = 1, nums2 = [], n = 0
        Output: [1]
        Explanation: The arrays we are merging are [1] and [].
        The result of the merge is [1].
        Example 3:
        
        Input: nums1 = [0], m = 0, nums2 = [1], n = 1
        Output: [1]
        Explanation: The arrays we are merging are [] and [1].
        The result of the merge is [1].
        Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
         
        
        Constraints:
        
        nums1.length == m + n
        nums2.length == n
        0 <= m, n <= 200
        1 <= m + n <= 200
        -109 <= nums1[i], nums2[j] <= 109

        */
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = 0;
            while (m < nums1.Length)
            {
                nums1[m++] = nums2[i++];
            }
            Array.Sort(nums1);
        }

        /*
        4.
        https://leetcode.com/problems/pascals-triangle/ 
        Given an integer numRows, return the first numRows of Pascal's triangle.

        In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
        
        Example 1:
        
        Input: numRows = 5
        Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
        Example 2:
        
        Input: numRows = 1
        Output: [[1]]
                
        Constraints:
        
        1 <= numRows <= 30
        */

        /* Using Pascal value theoram */
        //public static IList<IList<int>> Generate(int numRows)
        //{
        //    IList<IList<int>> numbers = new List<IList<int>>();
        //    int val = 1;
        //    for(int i = 0; i < 5; i++)
        //    {               
        //        List<int> rowNumbser = new List<int>();
        //        for(int j=0; j <= i; j++)
        //        {
        //            if (i == 0 || j == 0)
        //            {
        //                val = 1;
        //                rowNumbser.Add(val);
        //                continue;
        //            }
        //            val = val * (i - j + 1) / j;
        //            rowNumbser.Add(val);
        //        }
        //        numbers.Add(rowNumbser);
        //    }
        //    return numbers;
        //}

        /* using previous item in the list (previous row in the pyramid) */

        public static IList<IList<int>> GeneratePascalI(int numRows)
        {
            IList<IList<int>> numbers = new List<IList<int>>();
            if (numRows == 1)
            {
                return new List<IList<int>> { new List<int>() { 1 } };
            }
            for (int i = 0; i < numRows; i++)
            {
                List<int> rowNumbser = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0 || i == j)
                    {
                        rowNumbser.Add(1);
                    }
                    else
                    {
                        rowNumbser.Add(numbers[i - 1][j] + numbers[i - 1][j - 1]);
                    }
                }

                numbers.Add(rowNumbser);
            }
            return numbers;
        }

        /* 
        5.
        https://leetcode.com/problems/pascals-triangle-ii/ 

        Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.

        In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
        
        Example 1:
        
        Input: rowIndex = 3
        Output: [1,3,3,1]
        Example 2:
        
        Input: rowIndex = 0
        Output: [1]
        Example 3:
        
        Input: rowIndex = 1
        Output: [1,1]
         
        
        Constraints:
        
        0 <= rowIndex <= 33

        */
        //public static IList<int> GeneratePascalII(int rowIndex)
        //{
        //    IList<IList<int>> numbers = new List<IList<int>>();
        //    int numRows = rowIndex + 1;
        //    if (numRows == 1)
        //    {
        //        return new List<int>() { 1 } ;
        //    }
        //    for (int i = 0; i < numRows; i++)
        //    {
        //        List<int> rowNumbser = new List<int>();

        //        for (int j = 0; j <= i; j++)
        //        {
        //            if (j == 0 || i == 0 || i == j)
        //            {
        //                rowNumbser.Add(1);
        //            }
        //            else
        //            {
        //                rowNumbser.Add(numbers[i - 1][j] + numbers[i - 1][j - 1]);
        //            }
        //        }

        //        numbers.Add(rowNumbser);
        //    }
        //    return numbers[rowIndex];
        //}

        /* Using Pascal value theoram and calculated for the particular 
         row os no extra calculation for other rows!*/
        public static IList<long> GeneratePascalII(int rowIndex)
        {
            List<long> rowNumbser = new List<long>();
            long val = 1;
            for (int j = 0; j <= rowIndex; j++)
            {
                if (j == 0 || j == rowIndex)
                {
                    val = 1;
                    rowNumbser.Add(val);
                    continue;
                }
                val = val * (rowIndex - j + 1) / j;
                rowNumbser.Add(val);
            }
            return rowNumbser;
        }
    }
}

