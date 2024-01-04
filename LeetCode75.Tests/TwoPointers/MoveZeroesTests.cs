using LeetCode75.Main.TwoPointers;

namespace LeetCode75.Tests.TwoPointers
{
    internal class MoveZeroesTests
    {
        [TestCaseSource(nameof(GetTestCaseDatas))]
        public void TestExamples(int[] nums, int[] expected)
        {
            new MoveZeroes().MoveZeroesMethod(nums);
            Assert.That(nums, Is.EqualTo(expected));
        }

        private static IEnumerable<TestCaseData> GetTestCaseDatas()
        {
            yield return new TestCaseData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 });
            yield return new TestCaseData(new int[] { 0 }, new int[] { 0 });
            yield return new TestCaseData(new int[] { 1 }, new int[] { 1 });
            yield return new TestCaseData(new int[] { 1, 0 }, new int[] { 1, 0 });
            yield return new TestCaseData(new int[] { 0, 1 }, new int[] { 1, 0 });
            yield return new TestCaseData(new int[] { 2, 1 }, new int[] { 2, 1 });
            yield return new TestCaseData(new int[] { 4, 2, 4, 0, 0, 3, 0, 5, 1, 0 }, new int[] { 4, 2, 4, 3, 5, 1, 0, 0, 0, 0 });
        }
    }
}
