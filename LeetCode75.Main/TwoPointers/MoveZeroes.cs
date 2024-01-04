namespace LeetCode75.Main.TwoPointers;

public class MoveZeroes
{
    public void MoveZeroesMethod(int[] nums)
    {
        if (nums.Length == 1) return;
        int lastNullIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                bool isNullFound = false;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] == 0)
                    {
                        lastNullIndex = j;
                        isNullFound = true;
                        break;
                    }
                }

                if (isNullFound)
                {
                    nums[lastNullIndex] = nums[i];
                    nums[i] = 0;
                }    
            }
        }
    }
}
