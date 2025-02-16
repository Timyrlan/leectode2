using System.Diagnostics;
using Solutions.Easy.SlidingWindow;

namespace Solutions.Easy;

public class UnitTestEasySlidingWindow
{
    [TestCase(12.75000f, new[] { 1, 12, -5, -6, 50, 3 }, 4)]
    //[TestCase(2d, new[] { 0, 1, 1, 3, 3}, 4)]
    //[TestCase(2.8d, new[] { 4, 0, 4, 3, 3 }, 5)]
    //[TestCase(5, new[] { 5 }, 1)]
    public void Solution_283_Move_Zeroes(double expected, int[] nums, int k)
    {
        //Assert.That(new Solution_643_Maximum_Average_Subarray_I().FindMaxAverage(nums, k), Is.EqualTo(expected));

        var a = new Solution_643_Maximum_Average_Subarray_I();
        var sw1 = Stopwatch.StartNew();
        for (int i = 0; i < 100000000; i++)
        {
            a.FindMaxAverage(nums, k);
        }

        sw1.Stop();


        var sw2 = Stopwatch.StartNew();
        for (int i = 0; i < 100000000; i++)
        {
            a.FindMaxAverage2(nums, k);
        }

        sw2.Stop();

        var aa = sw1.ElapsedMilliseconds - sw2.ElapsedMilliseconds;

    }
}