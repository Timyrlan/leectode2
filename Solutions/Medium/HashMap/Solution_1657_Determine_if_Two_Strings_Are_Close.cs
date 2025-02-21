namespace Solutions.Medium.HashMap;

public class Solution_2215_Find_the_Difference_of_Two_Arrays
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length!= word2.Length) return false;

        var arr1 = new uint[256];
        var arr2 = new uint[256];

        foreach (var c in word1) arr1[c]++;

        foreach (var c in word2) arr2[c]++;

        for (var i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != 0 && arr2[i] == 0) return false;
            if (arr2[i] != 0 && arr1[i] == 0) return false;
        }

        using var aa1 = arr1.OrderByDescending(c => c).GetEnumerator();
        using var aa2 = arr2.OrderByDescending(c => c).GetEnumerator();

        for (var i = 0; i < arr1.Length; i++)
        {
            var next1 = aa1.MoveNext();
            var next2 = aa2.MoveNext();

            if (aa1.Current != aa2.Current) return false;

            if (aa1.Current == 0) break;
        }

        return true;
    }
}