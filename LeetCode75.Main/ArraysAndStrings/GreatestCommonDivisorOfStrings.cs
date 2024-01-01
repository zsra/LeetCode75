using System.Text;

namespace LeetCode75.Main.ArraysAndStrings;

public class GreatestCommonDivisorOfStrings
{
    public string GcdOfStrings(string str1, string str2)
    {
        int patternLength = str2.Length > str1.Length ? str1.Length : str2.Length;

        while (patternLength > 0) 
        {
            StringBuilder tempFirstPatternBuilder = new();
            StringBuilder tempSecondPatternBuilder = new();

            do
            {
                tempFirstPatternBuilder.Append(str2[..patternLength]);
            }
            while (tempFirstPatternBuilder.Length < str1.Length);

            do
            {
                tempSecondPatternBuilder.Append(str2[..patternLength]);
            }
            while (tempSecondPatternBuilder.Length < str2.Length);

            if (str1 == tempFirstPatternBuilder.ToString() 
                && str2 == tempSecondPatternBuilder.ToString())
            {
                return str2[..patternLength];
            }

            patternLength--;
        }

        return "";
    }
}
