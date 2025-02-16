namespace Solutions.Medium.TwoPointers;

public class UnitTestMediumTwoPointers
{
    [TestCase(49, new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 })]
    [TestCase(1, new[] { 1, 1 })]
    public void Solution_151_Reverse_Words_in_a_String(int expected, int[] height)
    {
        Assert.That(new Solution_11_Container_With_Most_Water().MaxArea(height), Is.EqualTo(expected));
    }

    [TestCase(2, new[] { 1, 2, 3, 4 }, 5)]
    [TestCase(1, new[] { 3, 1, 3, 4, 3 }, 6)]
    public void Solution_1679_Max_Number_of_K_Sum_Pairs(int expected, int[] nums, int k)
    {
        Assert.That(new Solution_1679_Max_Number_of_K_Sum_Pairs().MaxOperations(nums, k), Is.EqualTo(expected));
    }
}