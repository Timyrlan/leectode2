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
}