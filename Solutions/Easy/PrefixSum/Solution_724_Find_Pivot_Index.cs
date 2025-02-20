namespace Solutions.Easy.PrefixSum;

public class Solution_724_Find_Pivot_Index
{
    public int PivotIndex(int[] nums)
    {
        var summ = nums.Sum();
        var left = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (left == summ - left - nums[i]) return i;

            left += nums[i];
        }

        return -1;
    }
}