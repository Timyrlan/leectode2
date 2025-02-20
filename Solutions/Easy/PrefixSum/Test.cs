namespace Solutions.Easy.PrefixSum;

public class UnitTestEasySlidingWindow
{
    [TestCase(1, new[] { -5, 1, 5, 0, -7 })]
    [TestCase(0, new[] { -4, -3, -2, -1, 4, 3, 2 })]
    public void Solution_1732_Find_the_Highest_Altitude(double expected, int[] gain)
    {
        Assert.That(new Solution_1732_Find_the_Highest_Altitude().LargestAltitude(gain), Is.EqualTo(expected));
    }
}