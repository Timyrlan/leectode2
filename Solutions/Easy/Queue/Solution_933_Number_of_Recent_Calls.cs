namespace Solutions.Easy.Queue;

public class RecentCounter
{
    public RecentCounter()
    {
        Arr = new List<int>();
    }

    private int Last { get; set; }

    private List<int> Arr { get; }

    public int Ping(int t)
    {
        Arr.Add(t);
        var diff = t - 3000;
        while (Arr[Last] < diff) Last++;

        return Arr.Skip(Last).Count();
    }
}