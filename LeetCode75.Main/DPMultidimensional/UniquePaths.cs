namespace LeetCode75.Main.DPMultidimensional;

internal class UniquePaths
{
    public int UniquePathsMethod(int m, int n)
    {
        long ans = 1;
        
        for (int i = 1; i <= m - 1; i++)
        {
            ans = ans * (n - 1 + i) / i;
        }

        return (int)ans;
    }
}
