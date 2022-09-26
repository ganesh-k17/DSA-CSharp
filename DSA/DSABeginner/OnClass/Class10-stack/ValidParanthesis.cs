using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner.OnClass.Class10_stack
{
    public class ValidParanthesis
    {
        /*
        Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        An input string is valid if:
        
        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
        Every close bracket has a corresponding open bracket of the same type.
        
        Example 1:
        
        Input: s = "()"
        Output: true
        Example 2:
        
        Input: s = "()[]{}"
        Output: true
        Example 3:
        
        Input: s = "(]"
        Output: false
        
        Constraints:
        
        1 <= s.length <= 104
        s consists of parentheses only '()[]{}'.
        */
        public static bool Validate(string s)
        {
            Stack<char> stk = new Stack<char>();
            Dictionary<char, char> pairs = new Dictionary<char, char>()
            {
                {'(',')' },
                {'{','}' },
                {'[',']' }
            };
           
            foreach (var item in s)
            {
                if (stk.Count == 0)
                {
                    stk.Push(item);
                    continue;
                }

                if (pairs.ContainsKey(stk.Peek()) && pairs[stk.Peek()] == item)
                    stk.Pop();
                else
                    stk.Push(item);
            }
            return stk.Count ==0;
        }
    }
}
