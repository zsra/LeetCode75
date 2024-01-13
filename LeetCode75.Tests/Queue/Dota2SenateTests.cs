using LeetCode75.Main.Queue;

namespace LeetCode75.Tests.Queue;

[TestFixture]
internal class Dota2SenateTests
{
    [TestCase("RD", "Radiant")]
    [TestCase("RDD", "Dire")]
    public void TestExamples(string senate, string expected)
    {
        Assert.That(new Dota2Senate().PredictPartyVictory(senate), Is.EqualTo(expected));
    }
}
