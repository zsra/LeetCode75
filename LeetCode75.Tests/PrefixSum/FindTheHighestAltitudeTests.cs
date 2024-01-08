using LeetCode75.Main.PrefixSum;

namespace LeetCode75.Tests.PrefixSum
{
    [TestFixture]
    internal class FindTheHighestAltitudeTests
    {
        [TestCaseSource(nameof(GetTestCaseDatas))]
        public void TestExamples(int[] gain, int expected)
        {
            Assert.That(new FindTheHighestAltitude().LargestAltitude(gain), Is.EqualTo(expected));
        }

        private static IEnumerable<TestCaseData> GetTestCaseDatas()
        {
            yield return new TestCaseData(new int[] { -5, 1, 5, 0, -7 }, 1);
            yield return new TestCaseData(new int[] { -4, -3, -2, -1, 4, 3, 2 }, 0);
            yield return new TestCaseData(new int[] { 44, 32, -9, 52, 23, -50, 50, 33, -84, 47, -14, 84, 36, -62, 37, 81, -36, -85, -39, 67, -63, 64, -47, 95, 91, -40, 65, 67, 92, -28, 97, 100, 81 }, 781);
        }
    }
}