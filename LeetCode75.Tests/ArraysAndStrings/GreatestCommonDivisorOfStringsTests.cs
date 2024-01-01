using LeetCode75.Main.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

[TestFixture]
internal class GreatestCommonDivisorOfStringsTests
{
    [TestCase("ABCABC", "ABC", "ABC")]
    [TestCase("ABABAB", "ABAB", "AB")]
    [TestCase("LEET", "CODE", "")]
    [TestCase("TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXX")]
    public void TestExamples(string word1, string word2, string expected)
    {
        Assert.That(new GreatestCommonDivisorOfStrings().GcdOfStrings(word1, word2), Is.EqualTo(expected));
    }
}
