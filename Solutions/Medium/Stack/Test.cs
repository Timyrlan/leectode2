namespace Solutions.Medium.Stack;

public class Test
{
    [TestCase("lecoe", "leet**cod*e")]
    [TestCase("", "erase*****")]
    public void Solution_2390_Removing_Stars_From_a_String(string expected, string s)
    {
        Assert.That(new Solution_2390_Removing_Stars_From_a_String().RemoveStars(s), Is.EqualTo(expected));
    }
}