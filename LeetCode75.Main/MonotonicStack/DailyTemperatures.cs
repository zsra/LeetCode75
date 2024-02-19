namespace LeetCode75.Main.MonotonicStack;

internal class DailyTemperatures
{
    public int[] DailyTemperaturesMethod(int[] temperatures)
    {
        int[] results = new int[temperatures.Length];
        Stack<int> stack = new();
        
        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                int index = stack.Pop();
                results[index] = i - index;
            }

            stack.Push(i);
        }

        return results;
    }
}
