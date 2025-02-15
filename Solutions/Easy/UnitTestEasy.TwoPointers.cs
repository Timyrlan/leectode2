using Solutions.Easy.TwoPointers;

namespace Solutions.Easy;

public class UnitTestEasyTwoPointers
{
    [TestCase(new[] { 1, 3, 12, 0, 0 }, new[] { 0, 1, 0, 3, 12 })]
    [TestCase(new[] { 1, 1, 1, 3, 12 }, new[] { 1, 1, 1, 3, 12 })]
    [TestCase(new[] { 0 }, new[] { 0 })]
    public void Solution_283_Move_Zeroes(int[] expected, int[] nums)
    {
        Assert.That(new Solution_283_Move_Zeroes().MoveZeroes(nums), Is.EqualTo(expected));
    }


    [TestCase(true, "abc", "ahbgdc")]
    [TestCase(false, "axc", "ahbgdc")]
    public void Solution_392_Is_Subsequence(bool expected, string s, string t)
    {
        Assert.That(new Solution_392_Is_Subsequence().IsSubsequence(s, t), Is.EqualTo(expected));
    }
}