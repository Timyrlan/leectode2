namespace Solutions.Easy.HashMap;

public class Test
{
    [TestCase(true, new[] { 1, 2, 2, 1, 1, 3 })]
    [TestCase(false, new[] { 1, 2 })]
    [TestCase(true, new[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 })]
    public void Solution_1207_Unique_Number_of_Occurrences(bool expected, int[] arr)
    {
        Assert.That(new Solution_1207_Unique_Number_of_Occurrences().UniqueOccurrences(arr), Is.EqualTo(expected));
    }

    [TestCase(new[] { 1, 2, 3 }, new[] { 2, 4, 6 })]
    public void Solution_283_Move_Zeroes(int[] nums1, int[] nums2)
    {
        List<List<int>> expected = [new() { 1, 3 }, new() { 4, 6 }];
        Assert.That(new Solution_2215_Find_the_Difference_of_Two_Arrays().FindDifference(nums1, nums2), Is.EqualTo(expected));
    }


    [TestCase(new[] { 1, 2, 3, 3 }, new[] { 1, 1, 2, 2 })]
    public void Solution_283_Move_Zeroes2(int[] nums1, int[] nums2)
    {
        List<List<int>> expected = [new() { 3 }, new()];
        Assert.That(new Solution_2215_Find_the_Difference_of_Two_Arrays().FindDifference(nums1, nums2), Is.EqualTo(expected));
    }
}