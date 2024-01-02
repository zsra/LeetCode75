using LeetCode75.Main.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

[TestFixture]
internal class ReverseVowelsOfAStringTests
{
    [TestCase("hello", "holle")]
    [TestCase("leetcode", "leotcede")]
    public void TestExamples(string s, string expected)
    {
        Assert.That(new ReverseVowelsOfAString().ReverseVowels(s), Is.EqualTo(expected));
    }
}
