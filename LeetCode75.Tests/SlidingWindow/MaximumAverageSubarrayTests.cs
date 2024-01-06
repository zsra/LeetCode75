using LeetCode75.Main.SlidingWindow;

namespace LeetCode75.Tests.SlidingWindow;

[TestFixture]
internal class MaximumAverageSubarrayTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] nums, int k, double expected)
    {
        Assert.That(new MaximumAverageSubarray().FindMaxAverage(nums, k), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75);
        yield return new TestCaseData(new int[] { 5 }, 1, 5.00000);

    }
}
