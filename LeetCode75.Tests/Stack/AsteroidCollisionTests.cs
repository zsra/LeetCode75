using LeetCode75.Main.Stack;

namespace LeetCode75.Tests.Stack;

internal class AsteroidCollisionTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(int[] asteroids, int[] expected)
    {
        Assert.That(new AsteroidCollision().AsteroidCollisionMethod(asteroids), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new int[] { 5, 10, -5 }, new int[] { 5, 10 });
        yield return new TestCaseData(new int[] { 8, -8 }, new int[] { });
        yield return new TestCaseData(new int[] { 10, 2, -5 }, new int[] { 10 });
    }
}
