namespace Solutions.Medium.Queue;

public class Test
{
    [TestCase("Dire", "DDRRR")]
    [TestCase("Radiant", "RD")]
    [TestCase("Dire", "RDD")]
    [TestCase("Radiant", "DRRDRDRDRDDRDRDR")]
    public void Solution_649_Dota2_Senate(string expected, string s)
    {
        Assert.That(new Solution_649_Dota2_Senate().PredictPartyVictory(s), Is.EqualTo(expected));
    }
}