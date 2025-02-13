using Solutions.Medium.Array;

namespace Solutions.Medium;

public class Tests
{
    [TestCase("blue is sky the", "the sky is blue")]
    [TestCase("world hello", "  hello world  ")]
    [TestCase("example good a", "a good   example")]
    public void Solution_151_Reverse_Words_in_a_String(string expected, string s)
    {
        Assert.That(new Solution_151_Reverse_Words_in_a_String().ReverseWords(s), Is.EqualTo(expected));
    }

    [TestCase(new[] { 24, 12, 8, 6 }, new[] { 1, 2, 3, 4 })]
    [TestCase(new[] { 0, 0, 9, 0, 0 }, new[] { -1, 1, 0, -3, 3 })]
    public void Solution_238_Product_of_Array_Except_Self(int[] expected, int[] nums)
    {
        Assert.That(new Solution_238_Product_of_Array_Except_Self().ProductExceptSelf(nums), Is.EqualTo(expected));
    }
}