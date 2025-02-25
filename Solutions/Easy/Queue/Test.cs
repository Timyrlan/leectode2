namespace Solutions.Easy.Queue;

public class Test
{
    [Test]
    public void Solution_933_Number_of_Recent_Calls1()
    {
        var counter = new RecentCounter();
        Assert.That(counter.Ping(1), Is.EqualTo(1));
        Assert.That(counter.Ping(100), Is.EqualTo(2));
        Assert.That(counter.Ping(3001), Is.EqualTo(3));
        Assert.That(counter.Ping(3002), Is.EqualTo(3));
    }
    
    [Test]
    public void Solution_933_Number_of_Recent_Calls2()
    {
        var counter = new RecentCounter();
        Assert.That(counter.Ping(1), Is.EqualTo(1));
        Assert.That(counter.Ping(100), Is.EqualTo(2));
        Assert.That(counter.Ping(3001), Is.EqualTo(3));
        Assert.That(counter.Ping(3002), Is.EqualTo(3));
    }
}