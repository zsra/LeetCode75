namespace LeetCode75.Main.Graphs;

internal class ReorderRoutesToMakeAllPathsLeadToTheCityZero
{
    public int MinReorder(int n, int[][] connections)
    {
        var canReach0 = Enumerable.Repeat(false, n).ToList();
        canReach0[0] = true;
        var res = 0;

        while (canReach0.Any(x => x == false))
        {
            foreach (var connection in connections)
            {
                if (canReach0[connection[1]])
                {
                    canReach0[connection[0]] = true;
                }
                else if (canReach0[connection[0]])
                {
                    res += 1;
                    canReach0[connection[1]] = true;
                }
            }
        }

        return res;
    }
}
