namespace Solutions.Medium.HashMap;

public class Solution_2352_Equal_Row_and_Column_Pairs
{
    public int EqualPairs(int[][] grid)
    {
        var count = 0;
        var dic1 = new Dictionary<string, int>();

        for (var i = 0; i < grid.Length; i++)
        {
            var key = GetKey(grid[i]);
            if (!dic1.TryAdd(key, 1)) dic1[key]++;
        }

        for (var i = 0; i < grid.Length; i++)
        {
            var a = i;
            var code = GetKey(grid.Select(t => t[a]));

            if (dic1.TryGetValue(code, out var c)) count += c;
        }

        return count;
    }

    private string GetKey(IEnumerable<int> arr)
    {
        return string.Join(',', arr);
    }
}