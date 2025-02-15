namespace Solutions.Medium.Array;

/// <summary>
///     https://leetcode.com/problems/string-compression/description/?envType=study-plan-v2&envId=leetcode-75
/// </summary>
public class Solution_443_String_Compression
{
    public int Compress(char[] chars)
    {
        var currentCount = 0;
        
        var currentPosition = -1;
        for (var i = 0; i < chars.Length; i++)
        {
            currentCount++;

            if (i == chars.Length - 1 || chars[i + 1] != chars[i])
            {
                chars[++currentPosition] = chars[i];

                if (currentCount>1)
                {
                    var toAdd = currentCount.ToString();

                    foreach (char c in toAdd)
                    {
                        chars[++currentPosition] = c;
                    }
                }

                currentCount = 0;
            }
        }

        System.Array.Resize(ref chars, ++currentPosition);

        return currentPosition;
    }
}