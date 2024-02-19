namespace LeetCode75.Main.Intervals;

internal class MinimumNumberOfArrowsToBurstBalloons
{
    public int FindMinArrowShots(int[][] points)
    {
        if (points.Length <= 1)
        {
            return 1;
        }

        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
        
        int count = 1;
        int end = points[0][1];

        for (int i = 1; i < points.Length; i++)
        {
            if (points[i][0] > end)
            {
                count++;
                end = points[i][1];
            }
        }

        return count;
    }
}
