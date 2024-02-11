namespace LeetCode75.Main.Graphs;

internal class RottingOranges
{
    public int OrangesRotting(int[][] grid)
    {
        int[] dr = { 0, 0, -1, 1 };
        int[] dc = { 1, -1, 0, 0 };
        int fresh = 0;
        int time = 0;
        if (grid == null || grid[0].Length == 0)
            return 0;

        Queue<(int i, int j)> myq = new();
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1)
                    fresh++;
                else if (grid[i][j] == 2)
                    myq.Enqueue((i, j));
            }
        }

        if (fresh == 0)
            return 0;

        while (myq.Count > 0)
        {

            time++;
            int qsize = myq.Count;
            for (int y = 0; y < qsize; y++)
            {
                (int tr, int tc) = myq.Dequeue();
                for (int x = 0; x < 4; x++)
                {
                    int er = dr[x] + tr;
                    int ec = dc[x] + tc;

                    if (er >= 0 && er < grid.Length && ec >= 0 && ec < grid[0].Length && grid[er][ec] == 1)
                    {
                        grid[er][ec] = 2;
                        myq.Enqueue((er, ec));
                        fresh--;
                    }
                }
            }

        }

        return fresh == 0 ? time - 1 : -1;
    }
}
