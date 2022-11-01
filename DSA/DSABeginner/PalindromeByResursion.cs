using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{
    public static class PalindromeByResursion
    {
        public static bool Validate(string s)
        {
            if (s.Length == 1)
                return true;
            if (s[0] == s[s.Length - 1])
                return Validate(s.Substring(1, s.Length-2));
            return false;
        }
    }
}
