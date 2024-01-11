using System.Text;

namespace LeetCode75.Main.Stack;

public class RemovingStarsFromAString
{
    public string RemoveStars(string s)
    {
        Stack<char> stack = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '*')
                stack.Push(s[i]);
            else
                stack.Pop();
        }

        return string.Join("", stack.Reverse());
    }
}
