using LeetCode75.Main.HashMapAndSet;

namespace LeetCode75.Tests.HashMapAndSet;

[TestFixture]
internal class DetermineIfTwoStringsAreCloseTests
{
    [TestCase("abc", "bca", true)]
    [TestCase("a", "aa", false)]
    [TestCase("cabbba", "abbccc", true)]
    public void TestExamples(string word1, string word2, bool expected)
    {
        Assert.That(new DetermineIfTwoStringsAreClose().CloseStrings(word1, word2), Is.EqualTo(expected));
    }
}
