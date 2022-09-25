using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner.OnClass.Class10_stack
{    
    public class ContinuousDuplicateRemovalInText
    {
        /*
     You are given a string s consisting of lowercase English letters. A duplicate removal consists of choosing two adjacent and equal letters and removing them.

     We repeatedly make duplicate removals on s until we no longer can.
     
     Return the final string after all such duplicate removals have been made. It can be proven that the answer is unique.
     
     
     Example 1:
     
     Input: s = "abbaca"
     Output: "ca"
     Explanation: 
     For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.  The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".
     Example 2:
     
     Input: s = "azxxzy"
     Output: "ay"
      
     Constraints:
     
     1 <= s.length <= 105
     s consists of lowercase English letters. 
    */
        public static string RemoveDuplicates(string s)
        {
            Stack<char> stk = new Stack<char>();
            foreach (char c in s)
            {
                if (stk.Count > 0 && stk.Peek() == c)
                    stk.Pop();
                else
                    stk.Push(c);
            }

            return new string(stk.Select(s => s).ToArray().Reverse().ToArray());
        }

        /*
        You are given a string s and an integer k, a k duplicate removal consists of choosing k adjacent and equal letters from s and removing them, causing the left and the right side of the deleted substring to concatenate together.

        We repeatedly make k duplicate removals on s until we no longer can.
        
        Return the final string after all such duplicate removals have been made. It is guaranteed that the answer is unique.
        
        Example 1:
        
        Input: s = "abcd", k = 2
        Output: "abcd"
        Explanation: There's nothing to delete.
        Example 2:
        
        Input: s = "deeedbbcccbdaa", k = 3
        Output: "aa"
        Explanation: 
        First delete "eee" and "ccc", get "ddbbbdaa"
        Then delete "bbb", get "dddaa"
        Finally delete "ddd", get "aa"
        Example 3:
        
        Input: s = "pbbcggttciiippooaais", k = 2
        Output: "ps"
         
        Constraints:
        
        1 <= s.length <= 105
        2 <= k <= 104
        s only contains lowercase English letters.
    */

        public static string RemoveDuplicatesOfGivenNumberOfTimes(string s, int k)
        {
            Stack<Tuple<char, int>> stk = new Stack<Tuple<char, int>>();
            foreach (char c in s)
            {
                if (stk.Count == 0) {
                    stk.Push(Tuple.Create(c, 1));
                    continue;
                }
                
                Tuple<char, int> top = stk.Peek();

                if (top.Item1 == c && top.Item2 == k - 1)
                {
                    stk.Pop();
                }
                else if (top.Item1 == c)
                {
                    var count = top.Item2 + 1;
                    stk.Pop();
                    stk.Push(Tuple.Create(c, count));
                }
                else
                {
                    stk.Push(Tuple.Create(c, 1));
                }
            }

            string result = string.Empty;
            while(stk.Count > 0)
            {
                Tuple<char, int> stkItem = stk.Pop();
                for (int j = 0; j < stkItem.Item2; j++)
                {
                    result += stkItem.Item1;
                }
            }

            return new string(result.Reverse().ToArray());
        }
    }
}
