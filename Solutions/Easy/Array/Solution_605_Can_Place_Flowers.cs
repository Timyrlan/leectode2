namespace Solutions.Easy.Array;

public class Solution_605_Can_Place_Flowers
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        var count = 0;


        for (var i = 0; i < flowerbed.Length; i++)
        {
            var leftOk = i == 0 || flowerbed[i - 1] == 0;
            var rightOk = i >= flowerbed.Length - 1 || flowerbed[i + 1] == 0;
            var centerOk = flowerbed[i] == 0;
            if (leftOk && rightOk && centerOk)
            {
                flowerbed[i] = 1;
                count++;
                i++;
            }
        }


        return count >= n;
    }
}