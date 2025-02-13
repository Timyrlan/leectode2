using System.Text;

namespace Solutions.Easy;

public class Solution_1768_Merge_Strings_Alternately
{
    public string MergeAlternately(string word1, string word2)
    {
        var length = word1.Length > word2.Length ? word1.Length : word2.Length;

        var result = new List<char>();

        for (var i = 0; i < length; i++)
        {
            char? char1 = word1.Length > i ? word1[i] : null;
            char? char2 = word2.Length > i ? word2[i] : null;

            if (char1 != null) result.Add((char)char1);

            if (char2 != null && char2 != char1) result.Add((char)char2);
        }

        var sb = new StringBuilder();

        foreach (var c in result) sb.Append(c);

        return sb.ToString();
    }
}