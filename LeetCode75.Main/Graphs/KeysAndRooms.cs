namespace LeetCode75.Main.Graphs;

internal class KeysAndRooms
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var visited = new bool[rooms.Count];

        var stack = new Stack<int>();
        stack.Push(0);
        
        while (stack.Count > 0)
        {
            int curRoom = stack.Pop();
            visited[curRoom] = true;
            
            foreach (int room in rooms[curRoom])
            {
                if (!visited[room])
                {
                    stack.Push(room);
                }
            }
        }

        return visited.Min();
    }
}
