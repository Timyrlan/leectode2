namespace Solutions.Medium.Array;

public class Solution_334_Increasing_Triplet_Subsequence
{
    public bool IncreasingTriplet(int[] nums)
    {
        var num1 = int.MaxValue;
        var num2 = int.MinValue;

        foreach (var num in nums)
            if (num <= num1) num1 = num;
            else if (num <= num2) num2 = num;
            else return true;

        return false;
    }
}