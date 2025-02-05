namespace Tests_1768_Merge_Strings_Alternately;

public class Tests
{
    [TestCase("apbqcr", "abc", "pqr")]
    [TestCase("apbqrs", "ab", "pqrs")]
    [TestCase("apbqcd", "abcd", "pq")]
    public void Test1(string expected, string param1, string param2)
    {
        Assert.That(new Solution().MergeAlternately(param1, param2), Is.EqualTo(expected));
    }
}