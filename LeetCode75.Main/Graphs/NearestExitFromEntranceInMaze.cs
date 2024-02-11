namespace LeetCode75.Main.Graphs;

internal class NearestExitFromEntranceInMaze
{
    public int NearestExit(char[][] maze, int[] entrance)
    {
        int rows = maze.Length;
        int cols = maze[0].Length;
        int[][] directions = [[1,0], [-1,0], [0,1], [0,-1]];

        int startRow = entrance[0];
        int startCol = entrance[1];
        int distance = 0;
        maze[startRow][startCol] = '+';

        Queue<int[]> q = new();
        q.Enqueue([startRow, startCol, distance]);
        while (q.Count > 0)
        {
            int[] curr = q.Dequeue();
            int curRow = curr[0];
            int curCol = curr[1];
            int curdistance = curr[2];

            foreach (int[] dir in directions)
            {
                int nextRow = curRow + dir[0];
                int nextCol = curCol + dir[1];

                if (nextRow >= 0 && nextRow < rows && nextCol >= 0 && nextCol < cols && maze[nextRow][nextCol] == '.')
                {
                    if (nextRow == 0 || nextRow == rows - 1 || nextCol == 0 || nextCol == cols - 1)
                    {
                        return curdistance + 1;
                    }

                    maze[nextRow][nextCol] = '+';
                    q.Enqueue([nextRow, nextCol, curdistance + 1]);
                }

            }

        }
        return -1;
    }
}
