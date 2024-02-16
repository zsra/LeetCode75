namespace LeetCode75.Main.DP1D;

internal class DominoAndTrominoTiling
{
    public int NumTilings(int n)
    {
        switch (n)
        {
            case 1:
                return 1;
            case 2:
                return 2;
        }

        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        dp[2] = 2;

        for (int i = 3; i <= n; i++)
        {
            dp[i] = (int)((2.0 * dp[i - 1] + dp[i - 3]) % 1_000_000_007);
        }

        return dp[n];
    }
}
