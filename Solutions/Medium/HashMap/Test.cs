namespace Solutions.Medium.HashMap;

public class Test
{
    [TestCase(true, "abc", "bca")]
    [TestCase(false, "a", "aa")]
    [TestCase(true, "cabbba", "abbccc")]
    public void Solution_1207_Unique_Number_of_Occurrences(bool expected, string word1, string word2)
    {
        Assert.That(new Solution_2215_Find_the_Difference_of_Two_Arrays().CloseStrings(word1, word2), Is.EqualTo(expected));
    }
}