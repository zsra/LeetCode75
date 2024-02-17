namespace LeetCode75.Main.DPMultidimensional;

internal class EditDistance
{
    public int MinDistance(string word1, string word2)
    {
        int m = word1.Length;
        int n = word2.Length;
        int[,] memo = new int[m + 1, n + 1];
        
        for (int i = 1; i <= m; i++)
        {
            memo[i, 0] = i;
        }

        for (int i = 1; i <= n; i++)
        {
            memo[0, i] = i;
        }

        for (int i = 1; i < m + 1; i++)
        {
            for (int j = 1; j < n + 1; j++)
            {
                if (word1[i - 1] == word2[j - 1])
                {
                    memo[i, j] = memo[i - 1, j - 1];
                }
                else
                {
                    memo[i, j] = 1 + Math.Min(
                        Math.Min(memo[i - 1, j], memo[i, j - 1]), memo[i - 1, j - 1]
                    );
                }
            }
        }

        return memo[m, n];
    }
}
