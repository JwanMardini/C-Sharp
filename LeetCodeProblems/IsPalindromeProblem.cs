using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    class IsPalindromeProblem
    {
        public bool IsPalindrome(int x)
        {
            Console.WriteLine(x);
            string xToString = x.ToString();
            char[] xStringToChar = xToString.ToCharArray();
            Console.WriteLine(xToString);
            Array.Reverse(xStringToChar);
            
            if(xToString.Equals(new string(xStringToChar)))
            {
                return true;
            }
            return false;
        }
    }
}
