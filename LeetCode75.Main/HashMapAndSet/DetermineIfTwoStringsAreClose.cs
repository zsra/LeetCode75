using System.Text;

namespace LeetCode75.Main.HashMapAndSet;

public class DetermineIfTwoStringsAreClose
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        int[] word1Arr = new int[26];
        int[] word2Arr = new int[26];

        foreach (var item in word1)
        {
            word1Arr[item - 'a']++;
        }

        foreach (var item in word2)
        {
            word2Arr[item - 'a']++;
        }

        for (int i = 0; i < word1Arr.Length; i++)
        {
            if (word1Arr[i] == 0 && word2Arr[i] != 0 || word1Arr[i] != 0 && word2Arr[i] == 0)
            {
                return false;
            }
        }

        Array.Sort(word1Arr);
        Array.Sort(word2Arr);
        
        for (int i = 0; i < word1Arr.Length; i++)
        {
            if (word1Arr[i] != word2Arr[i]) return false;
        }

        return true;
    }
}
