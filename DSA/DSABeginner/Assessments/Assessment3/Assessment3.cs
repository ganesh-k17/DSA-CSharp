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
         Q1. Write an algorithm to determine if a number n is happy.

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
            int t = number;
            while (number > 0)
            {
                sum += (number % 10) * (number % 10);
                number = number / 10;
                if (number <= 0 && sum != 1)
                {
                    number = sum;
                    sum = 0;
                }
            }
            return sum;
        }

        /*
        Q2. Given an integer n, return true if it is a power of two. Otherwise, return false.

        An integer n is a power of two, if there exists an integer x such that n == 2x.
        
         
        
        Example 1:
        
        Input: n = 1
        Output: true
        Explanation: 20 = 1
        Example 2:
        
        Input: n = 16
        Output: true
        Explanation: 24 = 16
        Example 3:
        
        Input: n = 3
        Output: false
         
        
        Constraints:
        
        -231 <= n <= 231 - 1
         
        
        Follow up: Could you solve it without loops/recursion?
        */

        public static bool IsPowerOfTwo(int n)
        {
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                    return false;
            }
            return true;
        }

        /* // using log (without loop or recursive)
         
        public static bool isPowerOfTwo(int n)
        {

            if (n == 0)
                return false;

            return (int)(Math.Ceiling((Math.Log(n) / Math.Log(2)))) == (int)(Math.Floor(((Math.Log(n) / Math.Log(2)))));
        }
        */

        /* // using Recursive 
         
        public static bool IsPowerOfTwo(int n)
        {
            if (n == 1)
                return true;

            if (n % 2 != 0 || n == 0)
                return false;

            n = n / 2;

            return IsPowerOfTwo(n);
        }
        */

        /*
       Q3. Given two strings s and t, return true if t is an anagram of s, and false otherwise.

        An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
        
        Example 1:
        
        Input: s = "anagram", t = "nagaram"
        Output: true
        Example 2:
        
        Input: s = "rat", t = "car"
        Output: false
         
        
        Constraints:
        
        1 <= s.length, t.length <= 5 * 104
        s and t consist of lowercase English letters.
        
        
        Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
        */

        public static bool IsAnagram(string s, string t)
        {
            char[] sArray = s.ToArray();
            char[] tArray = t.ToArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            if (sArray.SequenceEqual(tArray))
                return true;

            return false;
        }

        /*
        Q4. An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.
        
        Given an integer n, return true if n is an ugly number.
        
        Example 1:
        
        Input: n = 6
        Output: true
        Explanation: 6 = 2 × 3
        Example 2:
        
        Input: n = 1
        Output: true
        Explanation: 1 has no prime factors, therefore all of its prime factors are limited to 2, 3, and 5.
        Example 3:
        
        Input: n = 14
        Output: false
        Explanation: 14 is not ugly since it includes the prime factor 7.
         
        Constraints:
        
        -231 <= n <= 231 - 1
         */
        public static bool IsUgly(int n)
        {
            return true;
        }

        /*
        Q5. Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        
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
        https://leetcode.com/problems/move-zeroes/
        */

        public void MoveZeroes(int[] nums)
        {
            int shift = 0;
            int n = nums.Length;
            int[] cloneNums = nums.ToArray();
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 0)
                {
                    for (; i < nums.Length - 1; i++)
                    {
                        nums[i] = nums[i + 1];
                    }

                    shift = shift + 1;
                    nums[(nums.Length) - shift] = 0;
                    i = 0;
                    n = n - 1;
                    continue;
                }
            }
        }

        public static string ReverseVowels(string s)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] textArray = s.ToArray();
            int n = textArray.Length;
            char[] orderedVowels = new char[s.Length];
            int count = 0;

            for (int i = n - 1; i >=0 ; i--)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (textArray[i] == vowels[j])                                                                                                                                                                                                
                    {
                        orderedVowels[count] = vowels[j];
                        count++;
                    }
                }
            }

            count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (textArray[i] == vowels[j])
                    {
                        textArray[i] = orderedVowels[count];
                        count++;
                        break;
                    }
                }
            }

            string myText = new string(textArray);

            return myText;
        }

        /*
        Q7. Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.
       
        Example 1:
        
        Input: nums = [3,2,1]
        Output: 1
        Explanation:
        The first distinct maximum is 3.
        The second distinct maximum is 2.
        The third distinct maximum is 1.
        Example 2:
        
        Input: nums = [1,2]
        Output: 2
        Explanation:
        The first distinct maximum is 2.
        The second distinct maximum is 1.
        The third distinct maximum does not exist, so the maximum (2) is returned instead.
        Example 3:
        
        Input: nums = [2,2,3,1]
        Output: 1
        Explanation:
        The first distinct maximum is 3.
        The second distinct maximum is 2 (both 2's are counted together since they have the same value).
        The third distinct maximum is 1.
        
        Constraints:
        
        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1
        
        Follow up: Can you find an O(n) solution?
        */

        public static int ThirdMax(int[] nums)
        {
            nums = nums.Distinct<int>().ToArray();
            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (first > nums[i])
                    first = nums[i];
                else if (second > nums[i] && second < first)
                    second = nums[i];
                else if (third > nums[i] && third < first && third < second)
                    third = nums[i];
            }
            return third;
        }

        /* Using library methods */
        //public static int ThirdMax(int[] nums)
        //{
        //    Array.Sort(nums, (a, b) => b.CompareTo(a));
        //    nums = nums.Distinct<int>().ToArray();
        //    return nums.Length > 2 ? nums[2] : nums[0];
        //}

        /*
         Q8. You are given two strings s and t.

         String t is generated by random shuffling string s and then add one more letter at a random position.
         
         Return the letter that was added to t.
         
         Example 1:
         
         Input: s = "abcd", t = "abcde"
         Output: "e"
         Explanation: 'e' is the letter that was added.
         Example 2:
         
         Input: s = "", t = "y"
         Output: "y"
         
         Constraints:
         
         0 <= s.length <= 1000
         t.length == s.length + 1
         s and t consist of lowercase English letters.
        */
        public static string xorIt(string key, string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
                sb.Append((char)(input[i] ^ key[(i % key.Length)]));

            String result = sb.ToString();

            return result;
        }

        /*
         Q9 You are given two strings s and t.

         String t is generated by random shuffling string s and then add one more letter at a random position.
         
         Return the letter that was added to t.
         
         Example 1:
         
         Input: s = "abcd", t = "abcde"
         Output: "e"
         Explanation: 'e' is the letter that was added.
         Example 2:
         
         Input: s = "", t = "y"
         Output: "y"
          
         Constraints:
         
         0 <= s.length <= 1000
         t.length == s.length + 1
         s and t consist of lowercase English letters. 
        */

        public static char FindTheDifference(string s, string t)
        {
            char[] sArray = s.ToArray();
            Array.Sort(sArray);
            char[] tArray = t.ToArray();
            Array.Sort(tArray);

            for (int i = 0; i < sArray.Length; i++)
            {
                if(sArray[i] != tArray[i])
                {
                    return tArray[i];
                }
            }

            return tArray[tArray.Length - 1];
        }

        /*
          Q10. Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

           Example 1:
          
          Input: num = 38
          Output: 2
          Explanation: The process is
          38 --> 3 + 8 --> 11
          11 --> 1 + 1 --> 2 
          Since 2 has only one digit, return it.
          Example 2:
          
          Input: num = 0
          Output: 0
           
          
          Constraints:
          
          0 <= num <= 231 - 1
           
          
          Follow up: Could you do it without any loop/recursion in O(1) runtime?
        */
        /* public static int addDigits(int num) // linear method
        {
            if (num == 0)
                return 0;

            while (true)
            {
                int sum = 0;
                while (num > 0)
                {
                    sum = sum + (num % 10);
                    num = num / 10;
                }
                num = sum;
                if (num > 0 && num <= 9)
                    break;
            }
            return num;
        }*/

        int addDigits(int num) // using remainder method
        {
            if (num == 0) 
                return 0;

            return num % 9 == 0 ? 9 : num % 9;
        }

        /*
        Q11 You are given a string s consisting of lowercase English letters, and an integer k.

        First, convert s into an integer by replacing each letter with its position in the alphabet (i.e., replace 'a' with 1, 'b' with 2, ..., 'z' with 26). Then, transform the integer by replacing it with the sum of its digits. Repeat the transform operation k times in total.

        For example, if s = "zbax" and k = 2, then the resulting integer would be 8 by the following operations:

        Convert: "zbax" ➝ "(26)(2)(1)(24)" ➝ "262124" ➝ 262124
        Transform #1: 262124 ➝ 2 + 6 + 2 + 1 + 2 + 4 ➝ 17
        Transform #2: 17 ➝ 1 + 7 ➝ 8
        Return the resulting integer after performing the operations described above.
        
        Example 1:

        Input: s = "iiii", k = 1
        Output: 36
        Explanation: The operations are as follows:
        - Convert: "iiii" ➝ "(9)(9)(9)(9)" ➝ "9999" ➝ 9999
        - Transform #1: 9999 ➝ 9 + 9 + 9 + 9 ➝ 36
        Thus the resulting integer is 36.
        Example 2:

        Input: s = "leetcode", k = 2
        Output: 6
        Explanation: The operations are as follows:
        - Convert: "leetcode" ➝ "(12)(5)(5)(20)(3)(15)(4)(5)" ➝ "12552031545" ➝ 12552031545 
        - Transform #1: 12552031545 ➝ 1 + 2 + 5 + 5 + 2 + 0 + 3 + 1 + 5 + 4 + 5 ➝ 33
        - Transform #2: 33 ➝ 3 + 3 ➝ 6
        Thus the resulting integer is 6.
        Example 3:

        Input: s = "zbax", k = 2
        Output: 8
 
        Constraints:

        1 <= s.length <= 100
        1 <= k <= 10
        s consists of lowercase English letters.
        */

        public static int GetLucky(string s, int k)
        {
            int n = 0;

            var txtArray = s.ToArray().Select(s => getPosition(s)).ToArray();
            var numText = string.Join("",txtArray);

            n = n + numText.Sum(i => (int)Char.GetNumericValue(i));

            for (int i = 0; i < k-1; i++)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum = sum + (n % 10);
                    n = n / 10;
                }
                n = sum;
                if (n > 0 && n <= 9)
                    break;
            }

            return n;
        }

        public static int getPosition(char c)
        {
            int index = char.ToUpper(c) - 64;
            return index;
        }
    }
}
