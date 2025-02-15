namespace Solutions.Medium.TwoPointers;

/// <summary>
///     https://leetcode.com/problems/max-number-of-k-sum-pairs/description/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class Solution_1679_Max_Number_of_K_Sum_Pairs
{
    public int MaxOperations(int[] nums, int k)
    {
        var dic = new Dictionary<int, int>();

        var totalCount = 0;

        foreach (var c in nums)
        {
            var diff = k - c;

            if (dic.TryGetValue(diff, out var count) && count > 0)
            {
                totalCount++;
                dic[diff] = count - 1;
            }
            else
            {
                if (!dic.TryAdd(c, 1)) dic[c] += 1;
            }
        }

        return totalCount;
    }
}