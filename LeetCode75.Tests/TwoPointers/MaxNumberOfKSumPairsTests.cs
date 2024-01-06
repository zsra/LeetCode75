using LeetCode75.Main.TwoPointers;

namespace LeetCode75.Tests.TwoPointers;

internal class MaxNumberOfKSumPairsTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] nums, int k, int expected)
    {
        Assert.That(new MaxNumberOfKSumPairs().MaxOperations(nums, k), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 1, 2, 3, 4 }, 5, 2);
        yield return new TestCaseData(new int[] { 3, 1, 3, 4, 3 }, 6, 1);
    }
}
