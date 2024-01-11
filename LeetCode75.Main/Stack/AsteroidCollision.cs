namespace LeetCode75.Main.Stack;

public class AsteroidCollision
{
    public int[] AsteroidCollisionMethod(int[] asteroids)
    {
        Stack<int> stack = [];

        foreach (int asteroid in asteroids)
        {
            if (asteroid > 0)
            {
                stack.Push(asteroid);
            }
            else
            {
                while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroid))
                {
                    stack.Pop();
                }

                if (stack.Count > 0 && stack.Peek() == Math.Abs(asteroid))
                {
                    stack.Pop();
                }
                else if ((stack.Count > 0 && stack.Peek() < 0) || stack.Count == 0)
                {
                    stack.Push(asteroid);
                }
            }
        }

        int[] ans = new int[stack.Count];
        int idx = ans.Length - 1;

        while (stack.Count > 0)
        {
            ans[idx--] = stack.Pop();
        }

        return ans;
    }
}
