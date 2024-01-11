using LeetCode75.Main.Stack;

namespace LeetCode75.Tests.Stack;

[TestFixture]
internal class DecodeStringTests
{
    [TestCase("3[a]2[bc]", "aaabcbc")]
    [TestCase("3[a2[c]]", "accaccacc")]
    [TestCase("2[abc]3[cd]ef", "abcabccdcdcdef")]
    public void TestExamples(string s, string expected)
    {
        Assert.That(new DecodeString().DecodeStringMethod(s), Is.EqualTo(expected));
    }
}
