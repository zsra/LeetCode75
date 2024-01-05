using LeetCode75.Main.TwoPointers;

namespace LeetCode75.Tests.TwoPointers;

internal class IsSubsequenceTests
{
    [TestCase("abc", "ahbgdc", true)]
    [TestCase("axc", "ahbgdc", false)]
    public void TestExamples(string s, string t, bool expected)
    {
        Assert.That(new IsSubsequence().IsSubsequenceMethod(s, t), Is.EqualTo(expected));
    }
}
