namespace LeetCode75.Main.SlidingWindow;

public class MaximumNumberOfVowelsInASubstringOfGivenLength
{
    public int MaxVowels(string s, int k)
    { 
        char[] chars = s.ToCharArray();
        char[] vowels = ['a', 'e', 'i', 'o', 'u'];
        int maxCount = chars[0..k].Count(c => vowels.Contains(c));
        int previousCount = maxCount;
        int index = 1;

        while (index + k <= chars.Length)
        {
            if (vowels.Contains(chars[index - 1]))
            {
                previousCount--;
            }

            if (vowels.Contains(chars[index + k - 1])) 
            {
                previousCount++;
            }


            if( previousCount > maxCount )
            {
                maxCount = previousCount;
            }

            index++;
        }

        return maxCount;
    }
}
