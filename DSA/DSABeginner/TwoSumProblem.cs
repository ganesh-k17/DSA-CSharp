using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{
    /*
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

    3 Approaches:\

    1. Two loops
    2. Hashmap
    3. Mystery

     */
    public class TwoSumProblem
    {
        // TC - O(n^2), SC - O(1)
        public static int[] FindByTwoLoopMethod(int[] input, int target)
        {
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = i+1; j < length-1; j++)
                {
                    if(input[i] + input[j] == target)
                    {
                        return new int[2] { i, j};
                    }
                }
            }
            return new int[] { };
        }

        /*
         1. Store all elements one by one from 0 to n-1 in hashmap -- i
         2. Travers again on array - for every curr element :
            2.1 required = {target-curr} check if hashmap has required value present ?
            2.2 YES -- ans
            2.3 No -- continue
         */
        public static int[] FindByHashMap(int[] input, int target)
        {
            int length = input.Length;
            Dictionary<int, int> hm = new Dictionary<int, int>();

            for (int i = 0; i < length; i++)
            {
                if (hm.ContainsKey(target - input[i]))
                    return new int[] { hm[target], i };
                else
                    hm.Add(input[i], i);
            }

            return new int[] { };
        }

        // (two point approach)
        public int[] FindByMystery(int[] input, int target) // TC - O(nlogn + n) , SC - O(1)
        {
            int length = input.Length;
            for (int i = 0; i < length; i++)
            {

            }

            return new int[] { };
        }
    }
}
