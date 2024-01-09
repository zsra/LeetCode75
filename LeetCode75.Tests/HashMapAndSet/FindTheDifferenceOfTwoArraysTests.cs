using LeetCode75.Main.HashMapAndSet;

namespace LeetCode75.Tests.HashMapAndSet;

[TestFixture]
internal class FindTheDifferenceOfTwoArraysTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] nums1, int[] nums2, IList<IList<int>> expected)
    {
        Assert.That(new FindTheDifferenceOfTwoArrays().FindDifference(nums1, nums2), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(
            new int[] { 1, 2, 3 }, 
            new int[] { 2, 4, 6 }, 
            new List<IList<int>>() { new List<int>() { 1, 3 }, new List<int>() { 4, 6 } });
        yield return new TestCaseData(
            new int[] { 1, 2, 3, 3 },
            new int[] { 1, 1, 2, 2 },
            new List<IList<int>>() { new List<int>() { 3 }, new List<int>() {} });
    }
}
