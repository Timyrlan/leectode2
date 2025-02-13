using Solutions.Easy.Array;

namespace Solutions.Easy;

public class UnitTestEasy
{
    [TestCase("apbqcr", "abc", "pqr")]
    [TestCase("apbqrs", "ab", "pqrs")]
    [TestCase("apbqcd", "abcd", "pq")]
    public void Test_1768_Merge_Strings_Alternately(string expected, string param1, string param2)
    {
        Assert.That(new Solution_1768_Merge_Strings_Alternately().MergeAlternately(param1, param2), Is.EqualTo(expected));
    }

    [TestCase("ABC", "ABCABC", "ABC")]
    [TestCase("AB", "ABABAB", "ABAB")]
    [TestCase("", "LEET", "CODE")]
    [TestCase("TAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX")]
    public void Test_1071_Greatest_Common_Divisor_of_Strings(string expected, string param1, string param2)
    {
        Assert.That(new Solution_1071_Greatest_Common_Divisor_of_Strings().GcdOfStrings(param1, param2), Is.EqualTo(expected));
    }

    [TestCase("ABC", "ABCABC", "ABC")]
    [TestCase("AB", "ABABAB", "ABAB")]
    [TestCase("", "LEET", "CODE")]
    [TestCase("TAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX")]
    public void Test_1071_Greatest_Common_Divisor_of_Strings2(string expected, string param1, string param2)
    {
        Assert.That(new Solution_1071_Greatest_Common_Divisor_of_Strings2().GcdOfStrings(param1, param2), Is.EqualTo(expected));
    }

    [TestCase(new[] { true, true, true, false, true }, new[] { 2, 3, 5, 1, 3 }, 3)]
    [TestCase(new[] { true, false, false, false, false }, new[] { 4, 2, 1, 1, 2 }, 1)]
    [TestCase(new[] { true, false, true }, new[] { 12, 1, 12 }, 10)]
    public void Solution_1431_Kids_With_the_Greatest_Number_of_Candies(bool[] expected, int[] candies, int extraCandies)
    {
        Assert.That(new Solution_1431_Kids_With_the_Greatest_Number_of_Candies().KidsWithCandies(candies, extraCandies), Is.EqualTo(expected.ToList()));
    }

    [TestCase(true, new[] { 1, 0, 0, 0, 1 }, 1)]
    [TestCase(false, new[] { 1, 0, 0, 0, 1 }, 2)]
    [TestCase(true, new[] { 1, 0, 0, 0, 0, 0, 1 }, 2)]
    public void Solution_605_Can_Place_Flowers(bool expected, int[] flowerbed, int n)
    {
        Assert.That(new Solution_605_Can_Place_Flowers().CanPlaceFlowers(flowerbed, n), Is.EqualTo(expected));
    }

    [TestCase("AceCreIm", "IceCreAm")]
    [TestCase("leetcode", "leotcede")]
    public void Solution_345_Reverse_Vowels_of_a_String(string expected, string s)
    {
        Assert.That(new Solution_345_Reverse_Vowels_of_a_String().ReverseVowels(s), Is.EqualTo(expected));
    }

    [TestCase("blue is sky the", "the sky is blue")]
    [TestCase("world hello", "  hello world  ")]
    [TestCase("example good a", "a good   example")]
    public void Solution_151_Reverse_Words_in_a_String(string expected, string s)
    {
        Assert.That(new Solution_151_Reverse_Words_in_a_String().ReverseWords(s), Is.EqualTo(expected));
    }
}