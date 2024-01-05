namespace LeetCode75.Main.TwoPointers;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int max = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int min = height[left] < height[right] ? height[left] : height[right];
            int width = right - left;

            if (max < min * width)
            {
                max = min * width;
            }

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return max;
    }
}
