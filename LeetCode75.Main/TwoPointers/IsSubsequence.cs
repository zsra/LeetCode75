namespace LeetCode75.Main.TwoPointers;

public class IsSubsequence
{
    public bool IsSubsequenceMethod(string s, string t)
    {
        if (string.IsNullOrEmpty(s)) return true;

        int currentIndex = 0;

        for (int i = 0; i < t.Length; i++) 
        {
            if (s[currentIndex] == t[i])
            {
                currentIndex++;

                if(currentIndex == s.Length)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
