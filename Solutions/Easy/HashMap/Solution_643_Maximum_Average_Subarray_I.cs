namespace Solutions.Easy.HashMap;

public class Solution_2215_Find_the_Difference_of_Two_Arrays
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var dic1 = new Dictionary<int, bool>();
        foreach (var i in nums1) dic1.TryAdd(i, false);

        var dic2 = new Dictionary<int, bool>();
        foreach (var i in nums2) dic2.TryAdd(i, false);

        var result = new List<IList<int>>();
        var result1 = new List<int>();
        foreach (var i in dic1.Keys)
            if (!dic2.ContainsKey(i))
                result1.Add(i);

        var result2 = new List<int>();
        foreach (var i in dic2.Keys)
            if (!dic1.ContainsKey(i))
                result2.Add(i);

        result.Add(result1);
        result.Add(result2);


        return result;
    }
}