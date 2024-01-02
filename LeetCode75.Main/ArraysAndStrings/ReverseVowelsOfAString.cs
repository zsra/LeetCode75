using System;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace LeetCode75.Main.ArraysAndStrings;

public class ReverseVowelsOfAString
{
    public string ReverseVowels(string s)
    {
        List<char> vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
        int left = 0;
        int right = s.Length - 1;
        char[] text = s.ToCharArray();

        while (left < right)
        {
            while (left < s.Length && !vowels.Contains(text[left]))
            {
                left++;
            }

            while (right > 0 && !vowels.Contains(text[right]))
            {
                right--;
            }

            if (left >= right)
            {
                break;
            }

            (text[left], text[right]) = (text[right], text[left]);

            left++;
            right--;
        }

        return new string(text);
    }
}
