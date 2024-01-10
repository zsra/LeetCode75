using LeetCode75.Main.HashMapAndSet;

namespace LeetCode75.Tests.HashMapAndSet;

[TestFixture]
internal class EqualRowAndColumnPairsTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[][] grid, int expected)
    {
        Assert.That(new EqualRowAndColumnPairs().EqualPairs(grid), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[][] { [3, 2, 1], [1, 7, 6], [2, 7, 7] }, 1);
    }
}
