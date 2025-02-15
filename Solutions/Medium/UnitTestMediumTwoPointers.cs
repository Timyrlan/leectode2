using Solutions.Medium.Array;
using Solutions.Medium.TwoPointers;

namespace Solutions.Medium;

public class UnitTestMediumTwoPointers
{
    [TestCase(49, new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 })]
    [TestCase(1, new[] { 1, 1 })]
    public void Solution_151_Reverse_Words_in_a_String(int expected, int[] height)
    {
        Assert.That(new Solution_11_Container_With_Most_Water().MaxArea(height), Is.EqualTo(expected));
    }
}