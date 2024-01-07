namespace LeetCode75.Main.SlidingWindow;

public class LongestSubarrayOfFirstAfterDeletingOneElement
{
    public int LongestSubarray(int[] nums)
    {
        int k = 1;
        int i = 0, j;
        for (j = 0; j < nums.Length; j++)
        {
            if (nums[j] == 0) k--;
            if (k < 0 && nums[i++] == 0) k++;
        }

        return j - i - 1;
    }
}
