namespace Solutions.Easy.TwoPointers;

public class Solution_392_Is_Subsequence
{
    public bool IsSubsequence(string s, string t)
    {
        if (string.IsNullOrEmpty(s)) return true;
        if (string.IsNullOrEmpty(t)) return false;

        var pos = 0;
        foreach (var t1 in t)
            if (t1 == s[pos] && ++pos == s.Length)
                return true;

        return false;
    }
}