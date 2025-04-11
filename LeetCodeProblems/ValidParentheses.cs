using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class ValidParentheses
    {
        private Stack<char> stack = new();
        public bool IsValid(string s)
        {
            char[] list = s.ToCharArray();

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == '{' || list[i] == '(' || list[i] == '[')
                {
                    stack.Push(list[i]);
                }
                else if (list[i] == '}' || list[i] == ')' || list[i] == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();

                    if ((list[i] == ')' && top != '(') || (list[i] == '}' && top != '{') || (list[i] == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;


        }
    }
}
