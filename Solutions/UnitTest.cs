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
}