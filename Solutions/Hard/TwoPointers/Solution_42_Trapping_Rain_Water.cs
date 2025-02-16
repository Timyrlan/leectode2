namespace Solutions.Hard.TwoPointers;

/// <summary>
///     https://leetcode.com/problems/trapping-rain-water/
/// </summary>
public class Solution_42_Trapping_Rain_Water
{
    public int Trap(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var leftHeight = height[left];
        var rightHeight = height[right];
        var summ = 0;

        while (left < right)
            if (height[left] <= height[right])
            {
                left++;
                var diff = leftHeight - height[left];
                if (diff > 0) summ += diff;
                if (leftHeight < height[left]) leftHeight = height[left];
            }
            else
            {
                right--;
                var diff = rightHeight - height[right];
                if (diff > 0) summ += diff;

                if (rightHeight < height[right]) rightHeight = height[right];
            }

        return summ;
    }
}