namespace LeetCode75.Main.Backtracking;

internal class LetterCombinationsOfAPhoneNumber
{
    readonly Dictionary<char, string> map = new()
    {
        {'2', "abc" }, {'3', "def"}, {'4', "ghi"},
        {'5', "jkl"}, {'6', "mno"}, {'7', "pqrs"},
        {'8', "tuv"}, {'9', "wxyz"}
    };

    public IList<string> LetterCombinations(string digits)
    {
        List<string> combinations = [];

        if (digits.Length == 0)
        {
            return combinations;
        }

        foreach (char c in map[digits[0]])
        {
            if (digits.Length == 1)
            {
                combinations.Add(c.ToString());
            }
            else
            {
                combinations.AddRange(
                    from string combination 
                    in LetterCombinations(digits[1..]) 
                    select c.ToString() + combination);
            }
        }

        return combinations;
    }
}
