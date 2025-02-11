namespace Solutions;

public class Tests
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
}