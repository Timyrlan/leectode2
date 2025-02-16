namespace Solutions.Easy.SlidingWindow;

public class Solution_643_Maximum_Average_Subarray_I
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;

        if (k == nums.Length) return nums.Sum() / (double)k;

        for (var i = 0; i < k; i++) sum += nums[i];

        var maxSum = sum;

        for (var i = 1; i <= nums.Length - k; i++)
        {
            sum -= nums[i - 1];
            sum += nums[i - 1 + k];

            if (sum > maxSum) maxSum = sum;
        }

        var result = maxSum / k;

        return result;
    }

    public double FindMaxAverage2(int[] nums, int k)
    {
        double maxSum = 0.0;
        for (int i = 0; i < k; i++)
        {
            maxSum += nums[i];
        }

        double currSum = maxSum;
        int left = 0;
        int right = k - 1;
        /*
        0   1   2   3   4   5
        1   12  -5  -6  50  3
        |           |
        */
        while (right < nums.Length)
        {
            currSum -= nums[left];
            left++;
            right++;
            if (right < nums.Length)
            {
                currSum += nums[right];
                maxSum = Math.Max(currSum, maxSum);
            }
        }

        return maxSum / k;
    }
}