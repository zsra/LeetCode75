using LeetCode75.Main.HashMapAndSet;

namespace LeetCode75.Tests.HashMapAndSet;

[TestFixture]
internal class UniqueNumberOfOccurrencesTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] arr, bool expected)
    {
        Assert.That(new UniqueNumberOfOccurrences().UniqueOccurrences(arr), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 1, 2, 2, 1, 1, 3 }, true);
        yield return new TestCaseData(new int[] { 1, 2 }, false);
        yield return new TestCaseData(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }, true);
    }
}
