namespace Solutions.Easy.HashMap;

public class Solution_1207_Unique_Number_of_Occurrences
{
    public bool UniqueOccurrences(int[] arr)
    {
        var dic = new Dictionary<int, int>();
        foreach (var c in arr)
        {
            if (!dic.TryAdd(c, 1))
            {
                dic[c] += 1;
            }
        }

        var dic2 = new Dictionary<int, bool>();

        foreach (var c in dic.Values)
        {
            if (!dic2.TryAdd(c, false))
            {
                return false;
            }
        }

        return true;
    }
}