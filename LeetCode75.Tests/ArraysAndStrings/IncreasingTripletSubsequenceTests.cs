using LeetCode75.Main.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

[TestFixture]
internal class IncreasingTripletSubsequenceTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] nums, bool expected)
    {
        Assert.That(new IncreasingTripletSubsequence().IncreasingTriplet(nums), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 1, 2, 3, 4, 5 }, true);
        yield return new TestCaseData(new int[] { 5, 4, 3, 2, 1 }, false);
        yield return new TestCaseData(new int[] { 2, 1, 5, 0, 4, 6 }, true);
        yield return new TestCaseData(new int[] { 20, 100, 10, 12, 5, 13 }, true);
        yield return new TestCaseData(new int[] { 0, 4, 2, 1, 0, -1, -3 }, false);
    }
}
