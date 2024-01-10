namespace LeetCode75.Main.HashMapAndSet;

public class EqualRowAndColumnPairs
{
    public int EqualPairs(int[][] grid)
    {
        int count = 0;
        int n = grid.Length;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                bool equal = true;
                for (int x = 0; x < n; x++)
                {
                    if (grid[i][x] != grid[x][j])
                    {
                        equal = false;
                        break;
                    }
                }
                if (equal) count++;
            }
        }

        return count;
    }
}