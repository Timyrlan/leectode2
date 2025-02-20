namespace Solutions.Medium.SlidingWindow;

public class Solution_1493_Longest_Subarray_of_1s_After_Deleting_One_Element
{
    public int LongestSubarray(int[] nums)
    {
        var current = 0;
        var maxLength = 0;
        while (current < nums.Length)
        {
            var length = 0;
            var used = false;
            for (var i = current; i < nums.Length; i++)
                if (nums[i] == 1)
                    length++;
                else
                {
                    if (!used)
                        used = true;
                    else
                        break;
                }

            if (!used) length--;

            if (maxLength < length) maxLength = length;
            current++;
        }

        return maxLength;
    }
}