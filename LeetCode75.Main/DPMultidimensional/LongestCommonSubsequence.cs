namespace LeetCode75.Main.DPMultidimensional;

internal class LongestCommonSubsequence
{
    public int LongestCommonSubsequenceMethod(string text1, string text2)
    {
        int[,] calculations = new int[text1.Length + 1, text2.Length + 1];
        for (int i = text1.Length - 1; i >= 0; i--)
        {
            for (int j = text2.Length - 1; j >= 0; j--)
            {
                if (text1[i] == text2[j])
                {
                    calculations[i, j] = 1 + calculations[i + 1, j + 1];
                }
                else
                {
                    calculations[i, j] = Math.Max(calculations[i + 1, j], calculations[i, j + 1]);
                }
            }
        }

        return calculations[0, 0];
    }
}
