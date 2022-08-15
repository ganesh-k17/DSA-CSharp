using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{

    /*
     Given a string s, reverse only all the vowels in the string and return it.

        The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both cases.
        
        Example 1:
        
        Input: s = "hello"
        Output: "holle"
        Example 2:
        
        Input: s = "leetcode"
        Output: "leotcede"
  
    */

    public class ReverseVowels
    {
        public static string Reverse(string s)
        {
            char[] vowels= new char[] { 'a','e','i','o','u' };
            char[] textArray = s.ToArray();
            int n = textArray.Length;
            char[] orderedVowels = new char[s.Length];
            int count = 0;

            for (int i = n-1; i > 0; i--)
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

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (textArray[i] == vowels[j])
                    {
                        textArray[i] = orderedVowels[count];
                        count++;
                    }
                }
            }

            string myText = new string(textArray);

            return myText;
        }
    }
}
