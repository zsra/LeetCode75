using LeetCode75.Main.SlidingWindow;

namespace LeetCode75.Tests.SlidingWindow;

[TestFixture]
internal class LongestSubarrayOfFirstAfterDeletingOneElementTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] nums, int expected)
    {
        Assert.That(new LongestSubarrayOfFirstAfterDeletingOneElement().LongestSubarray(nums), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 1, 1, 0, 1 }, 3);
        yield return new TestCaseData(new int[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 }, 5);
    }
}
