using LeetCode75.Main.SlidingWindow;

namespace LeetCode75.Tests.SlidingWindow;

internal class MaximumNumberOfVowelsInASubstringOfGivenLengthTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(string s, int k, int expected)
    {
        Assert.That(new MaximumNumberOfVowelsInASubstringOfGivenLength().MaxVowels(s, k), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData("abciiidef", 3, 3);
        yield return new TestCaseData("aeiou", 2, 2);
        yield return new TestCaseData("leetcode", 3, 2);
        yield return new TestCaseData("novowels", 1, 1);
        yield return new TestCaseData("tnfazcwrryitgacaabwm", 4, 3);
    }
}
