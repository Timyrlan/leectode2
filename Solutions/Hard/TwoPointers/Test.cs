namespace Solutions.Hard.TwoPointers;

public class Test
{
    [TestCase(6, new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 })]
    [TestCase(9, new[] { 4, 2, 0, 3, 2, 5 })]
    public void Solution_151_Reverse_Words_in_a_String(int expected, int[] height)
    {
        Assert.That(new Solution_42_Trapping_Rain_Water().Trap(height), Is.EqualTo(expected));
    }
}