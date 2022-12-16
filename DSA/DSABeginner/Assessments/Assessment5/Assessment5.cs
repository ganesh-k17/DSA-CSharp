using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        /* 
        6.
        https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        */
        public static int MaxProfit(int[] prices)
        {
            //int profit = 0;
            //for (int i = 0; i < prices.Length; i++)
            //{
            //    for (int j = i+1; j < prices.Length-1; j++)
            //    {
            //        int diff = prices[j] - prices[i];
            //        if(diff > 0 && diff > profit)
            //        {
            //            profit = diff;
            //        }
            //    }
            //}
            //return profit;

            //int lsf = int.MaxValue;
            //int op = 0;
            //int pist = 0;

            //for (int i = 0; i < prices.Length; i++)
            //{
            //    if (prices[i] < lsf)
            //    {
            //        lsf = prices[i];
            //    }
            //    pist = prices[i] - lsf;
            //    if (op < pist)
            //    {
            //        op = pist;
            //    }
            //}
            //return op;


            int min = int.MaxValue;
            int profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                int price = prices[i];
                if (price < min)
                {
                    min = price;
                    continue;  // if min then we dont need to calculate profit as we have to search for the next sale value
                }

                var diff = price - min;  // calculate diff if price is not minimum
                if (diff > profit)       // if diff > profit then diff will be the profit.
                    profit = diff;
            }
            return profit;
        }

        /* 
        7.
         https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
        */

        /*
        public static int MaxProfitII(int[] prices)
        {
            int profit = 0;
            int min = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                int price = prices[i];
                if (price < min)
                {
                    min = price;
                    continue;
                }
                var diff = price - min;
                profit += diff;  // Profit will be compount of all our gain.

                min = price;  // we have to reset the min value as we have selled the stock and purchasing again.
            }
            return profit;
        }
        */

        public static int MaxProfitII(int[] prices)
        {
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }
            return profit;
        }

        /*
         8.  https://leetcode.com/problems/majority-element/
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
         
        
        Follow-up: Could you solve the problem in linear time and in O(1) space?
         */
        /* public static int MajorityElement(int[] nums)
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
                     count++;
                     if (count > max)
                     {
                         max = count;
                         result = nums[i];
                     }
                 }

                 number = nums[i];

             }
             return result;
         }*/

        public static int MajorityElement(int[] nums)  // Boyer's moore voting algorithm  (This would only work for the constraint n/2 as mentioned in the problem)
        {

            int count = 0;
            int theElement = 0;

            foreach (int ele in nums)
            {
                if (count == 0)
                {
                    theElement = ele;
                }

                if (ele == theElement)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return theElement;
        }

        /*
         9. https://leetcode.com/problems/majority-element-ii/

        Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.
        
        Example 1:
        
        Input: nums = [3,2,3]
        Output: [3]
        Example 2:
        
        Input: nums = [1]
        Output: [1]
        Example 3:
        
        Input: nums = [1,2]
        Output: [1,2]
         
        
        Constraints:
        
        1 <= nums.length <= 5 * 104
        -109 <= nums[i] <= 109
         */

        public static IList<int> MajorityElementII(int[] nums)
        {
            int count1 = 0;
            int count2 = 0;

            int theElement1 = 0;
            int theElement2 = 0;

            foreach (int ele in nums)
            {
                if (count1 == 0)
                {
                    theElement1 = ele;
                }
                else if (count2 == 0)
                {
                    theElement2 = ele;
                }

                else if (ele == theElement1)
                {
                    count1++;
                }
                else if ((ele == theElement2))
                {
                    count2++;
                }
            }

            count1 = 0;
            count2 = 0;

            List<int> elements = new();

            foreach (int ele in nums)
            {
                if (ele == theElement1)
                    count1++;
                else if (ele == theElement2)
                    count2++;
            }

            if (count1 > nums.Length / 3)
                elements.Add(theElement1);

            if (count2 > nums.Length / 3)
                elements.Add(theElement2);

            return elements;
        }

        /* 
         10. https://leetcode.com/problems/missing-ranges/ 
        Given a sorted integer array nums, where the range of elements are in the inclusive range [lower, upper], return its missing ranges.

        Example:
        
        Input: nums = [0, 1, 3, 50, 75], lower = 0 and upper = 99,
        Output: ["2", "4->49", "51->74", "76->99"]
        The high level idea:
        
        Check each num in nums[]. Initialize another variable next = lower.
        
        If nums[i]< next: we jump to next num to check if it’s in range.
        If nums[i]== next: it means we find the first num in range. We increment the next target by one.
        If nums[i] > next: Add the missing range [next, nums[i] — 1]. Update the next value to nums[i] + 1.
        After we finished the above loop, we need to double check the final next value. If next ≤ upper, we still have a missing range [next, upper] to add.
        We create a separate function getRange(int unm1, int num2) to deal with two cases: num1 == num2 or num1 < num2

         */
        public static List<String> findMissingRanges(int[] nums, int lower, int upper)
        {
            List<string> results = new();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i == 0)
                {
                    if ((nums[0] - lower) == 0)
                        continue;
                    else if ((nums[0] - lower) == 1)
                        results.Add(Convert.ToString(lower));
                    else
                        results.Add($"{lower + 1}->{nums[0] - 1}");
                }
                else
                {
                    AddRange(results, nums[i], nums[i+1], false);
                }
            }

            AddRange(results, nums[nums.Length - 1], upper, true);

            return results;
        }

        private static void AddRange(List<string> results, int lower, int upper, bool isLast)
        {
            if ((upper - lower) == 1)
                return;
            if ((upper - lower) == 2)
                results.Add(Convert.ToString(lower +1 ));
            else {
                upper = isLast ? upper : upper - 1;
                results.Add($"{lower + 1}->{ upper }");
            }
        }

        /*
         11. https://leetcode.com/problems/3sum/ 
        Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        Notice that the solution set must not contain duplicate triplets.
        
        Example 1:
        
        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]
        Explanation: 
        nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        The distinct triplets are [-1,0,1] and [-1,-1,2].
        Notice that the order of the output and the order of the triplets does not matter.
        Example 2:
        
        Input: nums = [0,1,1]
        Output: []
        Explanation: The only possible triplet does not sum up to 0.
        Example 3:
        
        Input: nums = [0,0,0]
        Output: [[0,0,0]]
        Explanation: The only possible triplet sums up to 0.
         
        
        Constraints:
        
        3 <= nums.length <= 3000
        -105 <= nums[i] <= 105
        */
        public static IList<List<int>> ThreeSum(int[] nums)
        {
            //List<IList<int>> resutl = new();
            //Dictionary<int, int> hashMap = new();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    hashMap.Add(i, nums[i]);
            //}

            //for (int j = 0; j < nums.Length - 1; j++)
            //{
            //    for (int k = 1; k < nums.Length; k++)
            //    {
            //        int target = 0;
            //        int val = target - (nums[j] + nums[k]);
            //        int currentValue = -1;
            //        if( -1!=(currentValue = ContainsValue(hashMap, val, j, k)))
            //        {
            //            resutl.Add(new List<int>() { val, nums[j], nums[k] });
            //        }
            //    }
            //}

            //return new List<IList<int>>();


            List<List<int>> resutl = new();
            Dictionary<int, int> hashMap = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!hashMap.ContainsKey(nums[i]))
                    hashMap.Add(nums[i], i);
            }

            for (int j = 0; j < nums.Length - 1; j++)
            {
                for (int k = 1; k < nums.Length; k++)
                {
                    int target = 0;
                    int val = target - (nums[j] + nums[k]);
                    if (hashMap.ContainsKey(val) && hashMap[val] != j && hashMap[val] != k && j != k)
                    {
                        resutl.Add(new List<int>() { val, nums[j], nums[k] });
                        hashMap.Remove(val);
                    }
                }
            }

            var result = resutl.Distinct(new ArrayDistinct()).ToList();
            return result;
        }

        public static int ContainsValue(Dictionary<int,int> hashMap, int val,int index1, int index2)
        {
            for (int i = 0; i < hashMap.Count(); i++)
            {
                if (hashMap[i] == val && i != index1 && i != index2)
                    return hashMap[i];
            }
            return -1;
        }

        public static (int,int) ThreeSum1(int[] nums)
        {
            List<IList<int>> resutl = new();
            
            return (5,6);
        }


        /*
         https://leetcode.com/problems/3sum-smaller/  

        Given an array of n integers nums and a target, find the number of index triplets i, j, k with 0 <= i < j < k < n 
        that satisfy the condition nums[i] + nums[j] + nums[k] < target.

        For example, given nums = [-2, 0, 1, 3], and target = 2.

        Return 2. Because there are two triplets which sums are less than 2:

        [-2, 0, 1]
        [-2, 0, 3]
        */

        public static int Find3SumSmaller(int[] nums, int target)
        {
            int count = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                int l = i + 1;
                int r = nums.Length - 1;
                while (l < r)
                {
                    if (nums[i] + nums[l] + nums[r] < target)
                    {
                        count++; //count += r - l;
                        l++;
                    }
                    else
                        r--;
                }
            }
            return count;
        }
    }

    public class ArrayDistinct : IEqualityComparer<List<int>>
    {
        public bool Equals(List<int> x, List<int> y)
        {
            x.Sort();
            y.Sort();
            var isEqual =  x.SequenceEqual(y);
            return isEqual;
        }

        public int GetHashCode([DisallowNull] List<int> obj)
        {
            return 1;
        }

    }

}








