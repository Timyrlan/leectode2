namespace Solutions.Medium.Stack;

public class Test
{
    [TestCase("lecoe", "leet**cod*e")]
    [TestCase("", "erase*****")]
    public void Solution_2390_Removing_Stars_From_a_String(string expected, string s)
    {
        Assert.That(new Solution_2390_Removing_Stars_From_a_String().RemoveStars(s), Is.EqualTo(expected));
    }


    [TestCase(new[] { 5, 10 }, new[] { 5, 10, -5 })]
    [TestCase(new int[] { }, new[] { 8, -8 })]
    [TestCase(new[] { 10 }, new[] { 10, 2, -5 })]
    public void Solution_735_Asteroid_Collision(int[] expected, int[] asteroids)
    {
        Assert.That(new Solution_735_Asteroid_Collision().AsteroidCollision(asteroids), Is.EqualTo(expected));
    }

    [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaa", "3[3[3[a]]]")]
    [TestCase("aaaaaaaaa", "3[3[a]]")]
    [TestCase("aaabcbc", "3[a]2[bc]")]
    [TestCase("accaccacc", "3[a2[c]]")]
    [TestCase("abcabccdcdcdef", "2[abc]3[cd]ef")]
    [TestCase("ef", "ef")]
    [TestCase("zzzyypqjkjkefjkjkefjkjkefjkjkefyypqjkjkefjkjkefjkjkefjkjkefef", "3[z]2[2[y]pq4[2[jk]e1[f]]]ef")]
    public void Solution_394_Decode_String(string expected, string s)
    {
        Assert.That(new Solution_394_Decode_String().DecodeString(s), Is.EqualTo(expected));
    }

    [TestCase(9, new[] { "2", "1", "+", "3", "*" })]
    [TestCase(6, new[] { "4", "13", "5", "/", "+" })]
    [TestCase(22, new[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" })]
    public void Solution_150_Evaluate_Reverse_Polish_Notation(int expected, string[] tokens)
    {
        Assert.That(new Solution_150_Evaluate_Reverse_Polish_Notation().EvalRPN(tokens), Is.EqualTo(expected));
    }
}