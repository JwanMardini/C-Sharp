using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testCases = new List<(string input, int k, string description)>
            {
                ("?ab??a", 0, "Should return a valid palindrome like 'abbbba'"),
                ("guzzza", 1, "Should return 'NO' because more than 1 fix is needed"),
                ("?gad?bcc?dg?", 2, "Should return a valid palindrome"),
                ("racec?r", 1, "Should return 'racecar'"),
                ("?a?", 0, "Should return a palindrome like 'aaa'"),
                ("ab?ba", 0, "Middle ? should be handled: 'ababa'"),
                ("", 0, "Edge case: empty string → returns ''"),
                ("a", 0, "Single character is already a palindrome"),
                ("a?", 0, "Should return 'aa'"),
                ("a?b", 1, "Should return a valid palindrome with one change"),
                ("abcca", 1, "Needs 1 change → should return 'abcba'"),
                ("abcca", 0, "Needs 1 change → should return 'NO'")
            };

            var solver = new PalindromeWithKChanges();

            foreach (var (input, k, description) in testCases)
            {
                string result = solver.solution(input, k);
                Console.WriteLine($"Input: \"{input}\", K: {k} → Output: \"{result}\" ({description})");
            }
        }
    }
}
