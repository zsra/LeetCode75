namespace LeetCode75.Main.ArraysAndStrings;

public class KidsWithTheGreatestNumberOfCandies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int greatest = candies.Max();
        bool[] result = new bool[candies.Length];

        for (int index = 0; index < candies.Length; index++) 
        {
            if (candies[index] + extraCandies < greatest)
            {
                result[index] = false;
            }
            else
            {
                result[index] = true;
            }
        }

        return result;
    }
}
