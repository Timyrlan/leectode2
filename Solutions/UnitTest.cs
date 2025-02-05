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
}