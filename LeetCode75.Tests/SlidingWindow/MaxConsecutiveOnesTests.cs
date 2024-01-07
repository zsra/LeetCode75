using LeetCode75.Main.SlidingWindow;

namespace LeetCode75.Tests.SlidingWindow;

[TestFixture]
internal class MaxConsecutiveOnesTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] nums, int k, int expected)
    {
        Assert.That(new MaxConsecutiveOnes().LongestOnes(nums, k), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2, 6);
        yield return new TestCaseData(new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3, 10);
    }
}

