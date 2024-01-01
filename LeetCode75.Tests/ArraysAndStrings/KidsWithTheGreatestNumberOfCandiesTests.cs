using LeetCode75.Main.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

[TestFixture]
internal class KidsWithTheGreatestNumberOfCandiesTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] candies, int extraCandies, bool[] expected)
    {
        Assert.That(new KidsWithTheGreatestNumberOfCandies().KidsWithCandies(candies, extraCandies), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 2, 3, 5, 1, 3 }, 3, new bool [] { true, true, true, false, true });
        yield return new TestCaseData(new int[] { 4, 2, 1, 1, 2 }, 1, new bool [] { true, false, false, false, false });
        yield return new TestCaseData(new int[] { 12, 1, 12 }, 10, new bool [] { true, false, true });
    }
}
