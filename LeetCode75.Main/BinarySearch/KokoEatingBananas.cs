namespace LeetCode75.Main.BinarySearch;

internal class KokoEatingBananas
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int start = 1;
        int end = piles.Max();
        int result = int.MaxValue;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            int hours = 0;
            foreach (int pile in piles)
            {
                hours += (int)Math.Ceiling((double)pile / (double)mid);
            }
            if (hours < 0) break;
            if (hours <= h)
            {
                result = Math.Min(result, mid);
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }
        return result;
    }
}
