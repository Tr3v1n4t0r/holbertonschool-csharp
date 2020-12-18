using System;

namespace Text
{
    /// <summary>Class for string functions.</summary>
    public class Str
    {
        /// <summary>Checks if a string is a palindrome.</summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True is palindrome, else false.</returns>
        public static bool IsPalindrome(string s)
        {
            string base = "";
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                    base += Char.ToLower(c);
            }
            int j = 0;
            int k = base.Length - 1;
            while (j < k)
            {
                if (base[j] != base[k])
                    return false;
                j++;
                k++;
            }
            return true;
        }
    }
}
