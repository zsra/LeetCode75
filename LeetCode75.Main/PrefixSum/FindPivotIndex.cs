namespace LeetCode75.Main.PrefixSum;

public class FindPivotIndex
{
    public int PivotIndex(int[] nums)
    {
        int totalSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            totalSum += nums[i];
        }

        int leftSum = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSum * 2 == totalSum - nums[i])
            {
                return i;
            }
                
            leftSum += nums[i];
        }

        return -1;
    }
}
