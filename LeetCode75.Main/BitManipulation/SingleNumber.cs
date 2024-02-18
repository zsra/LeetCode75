namespace LeetCode75.Main.BitManipulation;

internal class SingleNumber
{
    public int SingleNumberMethod(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i += 2)
        {
            if (i == nums.Length - 1 || nums[i] != nums[i + 1])
            {
                return nums[i];
            }
        }

        return 0;
    }
}
