namespace LeetCode75.Main.TwoPointers;

public class MaxNumberOfKSumPairs
{
    public int MaxOperations(int[] nums, int k)
    {
        Dictionary<int, int> counts = [];
        int result = 0;

        foreach (int i in nums)
        {
            if(counts.ContainsKey(k - i) && counts[k - i] > 0)
            {
                result++;
                counts[k - i]--;
            }
            else
            {
                if (!counts.ContainsKey(i))
                {
                    counts[i] = 0;
                }
                counts[i]++;
            }
        }

        return result;
    }
}
