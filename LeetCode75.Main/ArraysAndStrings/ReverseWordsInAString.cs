namespace LeetCode75.Main.ArraysAndStrings;

public class ReverseWordsInAString
{
    public string ReverseWords(string s)
    {
        var words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        return string.Join(" ", words.Reverse());
    }
}
