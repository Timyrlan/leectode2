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

    private static readonly object[] Solution_2352_Equal_Row_and_Column_Pairs_Cases =
    {
        new object[] {1, new int[][]{ [3, 2, 1], [1, 7, 6], [2, 7, 7] } },   //case 1
        new object[] {3, new int[][]{ [3, 1, 2, 2], [1, 4, 4, 5], [2, 4, 2, 2], [2, 4, 2, 2] } },   //case 2
    };

    [TestCaseSource (nameof(Solution_2352_Equal_Row_and_Column_Pairs_Cases))]
    public void Solution_2352_Equal_Row_and_Column_Pairs(int expected, int[][] grid)
    {
        Assert.That(new Solution_2352_Equal_Row_and_Column_Pairs().EqualPairs(grid), Is.EqualTo(expected));
    }
}