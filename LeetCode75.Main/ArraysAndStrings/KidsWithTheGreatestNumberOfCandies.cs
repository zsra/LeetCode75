namespace LeetCode75.Main.ArraysAndStrings;

public class KidsWithTheGreatestNumberOfCandies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int greatest = candies.Max();
        List<bool> result = [];

        for (int index = 0; index < candies.Length; index++) 
        {
            if (candies[index] + extraCandies < greatest)
            {
                result.Add(false);
            }
            else
            {
                result.Add(true);
            }
        }

        return result;
    }
}
