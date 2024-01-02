using LeetCode75.Main.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

[TestFixture]
internal class CanPlaceFlowersTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] flowerbed, int n, bool expected)
    {
        Assert.That(new CanPlaceFlowers().CanPlaceFlowersMethod(flowerbed, n), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 1, 0, 0, 0, 1 }, 1, true );
        yield return new TestCaseData(new int[] { 1, 0, 0, 0, 1 }, 2, false );
        yield return new TestCaseData(new int[] { 1, 0, 0, 0, 0, 1 }, 2, false );
        yield return new TestCaseData(new int[] { 1, 0, 0, 0, 1, 0, 0 }, 2, true );
        yield return new TestCaseData(new int[] { 0, 1, 0 }, 1, false );
        yield return new TestCaseData(new int[] { 0, 0, 1, 0, 0 }, 1, true );
    }
}
