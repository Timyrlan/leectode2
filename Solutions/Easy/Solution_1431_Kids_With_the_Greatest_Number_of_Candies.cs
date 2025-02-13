namespace Solutions.Easy;

public class Solution_1431_Kids_With_the_Greatest_Number_of_Candies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var minRequired = candies.Max() - extraCandies;
        return candies.Select(c => c >= minRequired).ToArray();
    }
}