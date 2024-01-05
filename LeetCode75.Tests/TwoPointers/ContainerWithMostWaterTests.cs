using LeetCode75.Main.TwoPointers;

namespace LeetCode75.Tests.TwoPointers;

[TestFixture]
internal class ContainerWithMostWaterTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] height, int expected)
    {
        Assert.That(new ContainerWithMostWater().MaxArea(height), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49);
       
    }
}
