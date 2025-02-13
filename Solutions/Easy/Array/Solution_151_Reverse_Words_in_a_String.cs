namespace Solutions.Easy.Array;

public class Solution_151_Reverse_Words_in_a_String
{
    public string ReverseWords(string s)
    {
        var words = s.Split(' ').Select(c => c.Trim()).Where(c => !string.IsNullOrWhiteSpace(c));
        return string.Join(' ', words.Reverse());
    }
}