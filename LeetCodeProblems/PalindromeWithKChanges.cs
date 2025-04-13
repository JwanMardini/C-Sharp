/*
 * Given a string S containing lowercase letters and ?, and an integer K, 
 * replace the ? characters and change at most K other letters to form a palindrome. 
 * Return a valid palindrome or "NO" if it can't be done.
 */

using System;

namespace LeetCodeProblems;
public class PalindromeWithKChanges
{
    public string solution(string S, int K)
    {
        // If the input string is null or empty, return it as is
        if (string.IsNullOrEmpty(S))
            return S;

        char[] chars = S.ToCharArray();
        int length = chars.Length;
        char replacementChar = 'a';
        int changeCount = 0;
        // Build symmetry from both ends of the string
        for (int i = 0; i < length / 2; i++)
        {
            int j = length - i - 1;

            if (chars[i] == '?' && chars[j] != '?')
            {
                // If only left side is '?', copy the character from the right
                chars[i] = chars[j];
            }
            else if (chars[i] != '?' && chars[j] == '?')
            {
                // If only right side is '?', copy the character from the left
                chars[j] = chars[i];
            }
            else if (chars[i] == '?' && chars[j] == '?')
            {
                // If both sides are '?', fill with the default replacement character
                chars[i] = chars[j] = replacementChar;
            }
            else if (chars[i] != chars[j])
            {
                // If both characters are non-'?' but not equal
                if (changeCount < K)
                {
                    chars[i] = chars[j];
                    changeCount++;
                }
                else
                {
                    // Not enough changes left
                    return "NO";
                }
            }
        }
        // Handle middle character if string length is odd
        if (length % 2 == 1 && chars[length / 2] == '?')
        {
            chars[length / 2] = replacementChar;
        }
        // Ensure no '?' is left and validate final palindrome
        for (int i = 0; i < length / 2; i++)
        {
            int j = length - i - 1;

            if (chars[i] == '?') chars[i] = replacementChar;
            if (chars[j] == '?') chars[j] = replacementChar;

            if (chars[i] != chars[j])
            {
                return "NO";
            }
        }
        return new string(chars);

    }
}
