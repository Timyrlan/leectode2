namespace Solutions;

public class Solution_345_Reverse_Vowels_of_a_String
{
    private readonly Dictionary<char, bool> Vowels = new()
    {
        { 'A', true },
        { 'a', true },
        { 'E', true },
        { 'e', true },
        { 'I', true },
        { 'i', true },
        { 'O', true },
        { 'o', true },
        { 'U', true },
        { 'u', true }
    };


    public string ReverseVowels(string s)
    {
        var vowels = new List<int>(s.Length);

        var arr = s.ToCharArray();
        for (var i = 0; i < arr.Length; i++)
            if (Vowels.ContainsKey(arr[i]))
                vowels.Add(i);

        for (var i = 0; i < vowels.Count / 2; i++) (arr[vowels[i]], arr[vowels[^(i + 1)]]) = (arr[vowels[^(i + 1)]], arr[vowels[i]]);

        return new string(arr);
    }
}