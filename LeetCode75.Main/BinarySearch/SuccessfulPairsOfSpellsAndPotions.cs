namespace LeetCode75.Main.BinarySearch;

internal class SuccessfulPairsOfSpellsAndPotions
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);
        int[] retval = new int[spells.Length];
        for (int i = 0; i < spells.Length; i++)
        {
            int left = 0;
            int right = potions.Length - 1;
            int leftMostIdx = -1;

            while (left <= right)
            {
                int m = (left + right) / 2;
                if (((long)spells[i]) * potions[m] >= success)
                {
                    leftMostIdx = m;
                    right = m - 1;
                }
                else left = m + 1;
            }
            retval[i] = leftMostIdx == -1 ? 0 : potions.Length - leftMostIdx;
        }

       return retval;
    }
}
