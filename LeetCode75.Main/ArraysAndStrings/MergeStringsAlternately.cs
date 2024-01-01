using System.Text;

namespace LeetCode75.Main.ArraysAndStrings;

public class MergeStringsAlternately
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder builder = new();
        int maxLength = word1.Length >= word2.Length ? word1.Length : word2.Length;

        for (int index = 0; index < maxLength; index++)
        {
            if (word1.Length > index) builder.Append(word1[index]);
            if (word2.Length > index) builder.Append(word2[index]);
        }

        return builder.ToString();
    }
}
