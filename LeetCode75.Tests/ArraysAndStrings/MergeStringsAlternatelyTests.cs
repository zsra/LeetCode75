using LeetCode75.Main.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

[TestFixture]
public class MergeStringsAlternatelyTests
{

    [TestCase("abc", "pqr", "apbqcr")]
    [TestCase("ab", "pqrs", "apbqrs")]
    [TestCase("abcd", "pq", "apbqcd")]
    public void TestExamples(string word1, string word2, string expected)
    {
        Assert.That(new MergeStringsAlternately().MergeAlternately(word1, word2), Is.EqualTo(expected));
    }
}