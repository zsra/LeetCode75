namespace LeetCode75.Main.MonotonicStack;

public class StockSpanner
{
    private readonly Stack<(int price, int day)> stack;
    private int day;

    public StockSpanner() => stack = new();

    public int Next(int price)
    {
        day++;
        
        while (stack.Count > 0 && stack.Peek().price <= price)
        {
            stack.Pop();
        }

        var span = day - (stack.Count > 0 ? stack.Peek().day : 0);
        stack.Push((price, day));

        return span;
    }
}