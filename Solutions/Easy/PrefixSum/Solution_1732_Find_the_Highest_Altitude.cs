namespace Solutions.Easy.PrefixSum;

public class Solution_1732_Find_the_Highest_Altitude
{
    public int LargestAltitude(int[] gain)
    {
        var currentAltitude = 0;
        var maxAltitude = 0;
        foreach (var c in gain)
        {
            currentAltitude = currentAltitude + c;
            if (currentAltitude > maxAltitude) maxAltitude = currentAltitude;
        }

        return maxAltitude;
    }
}