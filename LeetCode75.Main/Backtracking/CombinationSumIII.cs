namespace LeetCode75.Main.Backtracking;

internal class CombinationSumIII
{
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        List<IList<int>> results = [];
        Stack<int> stack = new();
        
        FindSum(1, k, n);
        
        return results;

        void FindSum(int startingValue, int numberOfNumbers, int targetSum)
        {
            if (targetSum is 0 && numberOfNumbers is 0) results.Add(stack.ToArray());
            if (targetSum is 0 || numberOfNumbers is 0) return;

            for (int value = startingValue; value < 10; value++)
            {
                stack.Push(value);
                FindSum(value + 1, numberOfNumbers - 1, targetSum - value);
                stack.Pop();
            }
        }
    }
}
