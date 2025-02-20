namespace Solutions.Medium.SlidingWindow;

public class Solution_1004_Max_Consecutive_Ones_III
{
    public int LongestOnes(int[] nums, int k)
    {
        var maxLength = 0;
        var start = 0;

        while (start < nums.Length - maxLength)
        {
            var length = 0;
            var zeroes = k;

            for (var i = start; i < nums.Length && zeroes >= 0; i++)
            {
                if (nums[i] == 0) zeroes--;
                if (zeroes < 0) break;

                length++;
            }

            start++;

            if (maxLength < length) maxLength = length;
        }

        return maxLength;
    }
}