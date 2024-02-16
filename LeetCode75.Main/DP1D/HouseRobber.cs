namespace LeetCode75.Main.DP1D;

internal class HouseRobber
{
    public int Rob(int[] nums)
    {
        int prevMax = 0;
        int currMax = 0;

        foreach (int num in nums)
        {
            int temp = currMax;
            currMax = Math.Max(prevMax + num, currMax);
            prevMax = temp;
        }

        return currMax;
    }
}
