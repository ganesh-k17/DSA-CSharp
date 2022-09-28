using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSABeginner
{
    /*
     https://iq.opengenus.org/string-isomorphism/ 
     
     Two strings S1 and S2 are said to be isomorphic if there exists a one-one mapping for every character in string S1 to a character in string S2 and the order of characters should be preserved.

     Two strings S1 and S2 are isomorphic if each unique character in string S1 can be replaced to get string S2 while preserving the order of the characters.
     
     Example 1: Consider strings "BCVB" and "LKOL".
     The strings are isomorphic as there exists a mapping of characters,
     'B' -> 'L'
     'C' -> 'K'
     'V' -> 'O'
     'B' -> 'L'
     
     Example 2: Consider strings "PINK" and "LOOT".
     The strings are not isomorphic because there are 4 unique characters in the first string "PINK" but there are only 3 unique characters in the string "LOOT", hence a one to one mapping from characters of the first string to characters of the second string is not possible.
     
     Implementation
     Problem- Given two strings S1 and S2, the program must return "true" or 1 as the output if the strings are isomorphic else it should return "false" or 0 as the output.
     
     We can implement the string isomorphism problem in the following two ways:
     
     Naive solution
     Solution using hashing

     WXYZABCXYZ and PQRSTUVQRS are isomorphic.
     YWSUIOD and QRUSJHS are not isomorphic.

     */
    public class StringIsIsomorphism
    {
        public static bool isIsoMorphism(string str)
        {
            return true;
        }
    }
}
