namespace Solutions.Medium.TwoPointers;

/// <summary>
///     https://leetcode.com/problems/container-with-most-water/description/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class Solution_11_Container_With_Most_Water
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var maxSquare = 0;
        while (left <= right)
            if (height[left] <= height[right])
            {
                var sqaure = height[left] * (right - left);
                if (sqaure > maxSquare) maxSquare = sqaure;
                left++;
            }
            else
            {
                var sqaure = height[right] * (right - left);
                if (sqaure > maxSquare) maxSquare = sqaure;
                right--;
            }

        return maxSquare;
    }
}