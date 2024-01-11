using System.Text;

namespace LeetCode75.Main.Stack;
public class DecodeString
{
    public string DecodeStringMethod(string s)
    {
        Stack<string> strings = new();
        Stack<int> numbers = new();

        StringBuilder builder = new();
        int currentNumber = 0;

        foreach (char c in s)
        {
            if (c == '[')
            {
                strings.Push(builder.ToString());
                numbers.Push(currentNumber);
                builder.Clear();
                currentNumber = 0;
            }
            else if (c == ']')
            {
                string currentString = builder.ToString();
                builder.Clear();
                builder.Append(strings.Pop() + string.Join("", Enumerable.Repeat(currentString, numbers.Pop())));
            }
            else if (int.TryParse(c.ToString(), out int n))
            {
                currentNumber = currentNumber * 10 + n;
            }
            else
            {
                builder.Append(c);
            }
        }

        return builder.ToString();
    }
}
