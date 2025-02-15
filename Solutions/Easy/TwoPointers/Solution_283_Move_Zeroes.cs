namespace Solutions.Easy.TwoPointers;

public class Solution_283_Move_Zeroes
{
    public int[] MoveZeroes(int[] nums)
    {
        if (nums.Length < 2) return nums;

        var currentPos = -1;
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] != 0)
                nums[++currentPos] = nums[i];

        for (var i = ++currentPos; i < nums.Length; i++) nums[i] = 0;

        return nums;
    }
}