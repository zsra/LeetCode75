namespace LeetCode75.Main.ArraysAndStrings;

public class IncreasingTripletSubsequence
{
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums == null || nums.Length < 3)
        {
            return false;
        }

        int a = int.MaxValue;
        int b = int.MaxValue;

        foreach (int num in nums)
        {
            if (num <= a)
            {
                a = num;
            }
            else if (num <= b) 
            {
                b = num;
            }
            else return true;
        }

        return false;
    }
}
