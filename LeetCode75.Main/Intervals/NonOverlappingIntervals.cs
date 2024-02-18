namespace LeetCode75.Main.Intervals;

internal class NonOverlappingIntervals
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (x, y) => x[1].CompareTo(y[1]));

        int nEdge = intervals[0][1];
        int nRemoveCount = 0;

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] >= nEdge)
            {
                nEdge = intervals[i][1];
            }
            else
            {
                nRemoveCount++;
            }
        }

        return nRemoveCount;
    }
}
