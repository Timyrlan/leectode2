namespace Solutions.Medium.Array;

/// <summary>
///     https://leetcode.com/problems/subarray-sum-equals-k/editorial/
/// </summary>
public class Solution_Subarray_Sum_Equals_K
{
    public int SubarraySum(int[] nums, int k)
    {
       
        var countArrays = 0;
        var sum = 0;
        var dic = new Dictionary<int, int> { [0] = 1 };

        foreach (var t in nums)
        {
            sum += t;

            var dif = sum - k;

            if (dic.TryGetValue(dif, out var countEntries)) countArrays += countEntries;

            if (!dic.TryAdd(sum, 1)) dic[sum]++;
        }

        return countArrays;
    }
}