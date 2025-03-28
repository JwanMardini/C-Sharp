using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    class RomanToIntProblem
    {
        /*
         Symbol       Value
            I             1
            V             5
            X             10
            L             50
            C             100
            D             500
            M             1000
         */
        private readonly Dictionary<char, int> romanChar = new() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        public  int RomanToInt(string s)
        {
            char[] sToChar = s.ToCharArray();

            // Handle single character case correctly
            if (sToChar.Length == 1)
            {
                if (romanChar.ContainsKey(sToChar[0]))
                {
                    return romanChar[sToChar[0]];
                }
                else
                {
                    return 0;
                }
            }

            int result = 0;

            for (int i = 0; i < sToChar.Length; i++)
            {
                // Ensure we don't go out of bounds before accessing the next character
                if (i < sToChar.Length - 1 && romanChar[sToChar[i]] < romanChar[sToChar[i + 1]])
                {
                    result -= romanChar[sToChar[i]];
                }
                else
                {
                    result += romanChar[sToChar[i]];
                }
            }

            return result;
        }


    }
}
