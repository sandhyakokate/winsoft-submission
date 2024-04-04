// Q2: Given a string s, find the length of the longest substring without repeating characters.
// Example 1:
// Input: s = "abcabcbb"
// Output: 3
// Explanation: The answer is "abc", with the length of 3.
// Example 2:

// Input: s = "bbbbb"
// Output: 1
// Explanation: The answer is "b", with the length of 1.
// Example 3:

// Input: s = "pwwkew"
// Output: 3
// Explanation: The answer is "wke", with the length of 3.
// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 
// Constraints:

// 0 <= s.length <= 5 * 104
// s consists of English letters, digits, symbols and spaces.

// -------->

using System;
using System.Collections.Generic;

class Program
{
    static int LengthOfLongestSubstring(string s)
    {
        // Handle empty string case
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        // Use a dictionary to efficiently track character positions
        Dictionary<char, int> charLastSeen = new Dictionary<char, int>();
        int left = 0; // Left index of the current substring
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char currentChar = s[right];

            // If the character is already seen within the current substring
            if (charLastSeen.ContainsKey(currentChar))
            {
                // Move left to the right of the last occurrence of the character
                left = Math.Max(left, charLastSeen[currentChar] + 1);
            }

            // Update character's last seen position
            charLastSeen[currentChar] = right;

            // Update maxLength
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();

        int length = LengthOfLongestSubstring(s);
        Console.WriteLine("Length of longest substring without repeating characters: " + length);
    }
}

