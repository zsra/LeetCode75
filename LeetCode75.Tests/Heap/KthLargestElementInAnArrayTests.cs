using LeetCode75.Main.Heap;

namespace LeetCode75.Tests.Heap;

[TestFixture]
internal class KthLargestElementInAnArrayTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] nums, int k, int expected)
    {
        Assert.That(new KthLargestElementInAnArray().FindKthLargest(nums, k), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 3, 2, 1, 5, 6, 4 }, 2, 5);
        yield return new TestCaseData(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, 4);
    }
}
