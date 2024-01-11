using LeetCode75.Main.Stack;

namespace LeetCode75.Tests.Stack;

[TestFixture]
internal class RemovingStarsFromAStringTests
{
    [TestCase("leet**cod*e", "lecoe")]
    [TestCase("erase*****", "")]
    public void TestExamples(string s, string expected)
    {
        Assert.That(new RemovingStarsFromAString().RemoveStars(s), Is.EqualTo(expected));
    }
}
