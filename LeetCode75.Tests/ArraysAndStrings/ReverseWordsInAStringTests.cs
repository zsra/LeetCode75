using LeetCode75.Main.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

[TestFixture]
internal class ReverseWordsInAStringTests
{
    [TestCase("the sky is blue", "blue is sky the")]
    [TestCase("  hello world  ", "world hello")]
    [TestCase("a good   example", "example good a")]
    public void TestExamples(string s, string expected)
    {
        Assert.That(new ReverseWordsInAString().ReverseWords(s), Is.EqualTo(expected));
    }
}
