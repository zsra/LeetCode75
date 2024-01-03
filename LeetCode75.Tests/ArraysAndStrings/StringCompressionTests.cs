using LeetCode75.Main.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

[TestFixture]
internal class StringCompressionTests
{
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void TestExamples(char[] chars, int expected)
    {
        Assert.That(new StringCompression().Compress(chars), Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> GetTestCaseDatas()
    {
        yield return new TestCaseData(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }, 6);
    }
}
