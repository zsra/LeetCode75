using LeetCode75.Main.PrefixSum;

namespace LeetCode75.Tests.PrefixSum;

[TestFixture]
internal class FindPivotIndexTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] nums, int expected)
    {
        Assert.That(new FindPivotIndex().PivotIndex(nums), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 1, 7, 3, 6, 5, 6 }, 3);
        yield return new TestCaseData(new int[] { 1, 2, 3 }, -1);
    }
}
