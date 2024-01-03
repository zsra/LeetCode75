namespace LeetCode75.Main.ArraysAndStrings;

public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] asnwer = new int[nums.Length];
        asnwer[0] = 1;
        int suffix = 1;

        for(int i = 1; i < nums.Length; i++) 
        {
            asnwer[i] = asnwer[i - 1] * nums[i - 1];
        }

        for (int i = nums.Length - 1; i >= 0; i--) 
        {
            asnwer[i] *= suffix;
            suffix *= nums[i];
        }

        return asnwer;
    }
}
