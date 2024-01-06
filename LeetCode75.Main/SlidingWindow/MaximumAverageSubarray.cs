namespace LeetCode75.Main.SlidingWindow;

public class MaximumAverageSubarray
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int index = 1;
        double previousSum = nums[0..k].Sum();
        double maxAvg = previousSum / k;

        while (index + k <= nums.Length)
        {
            double sum = previousSum - nums[index - 1] + nums[index + k - 1];

            if ((sum / k) > maxAvg)
            {
                maxAvg = (sum / k);
            }

            previousSum = sum;

            index++;
        }

        return maxAvg;
    }
}
