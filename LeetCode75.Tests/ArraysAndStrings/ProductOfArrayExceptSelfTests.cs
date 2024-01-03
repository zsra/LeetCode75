using LeetCode75.Main.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

[TestFixture]
internal class ProductOfArrayExceptSelfTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] nums, int[] expected)
    {
        Assert.That(new ProductOfArrayExceptSelf().ProductExceptSelf(nums), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 });
        yield return new TestCaseData(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 });
    }
}
