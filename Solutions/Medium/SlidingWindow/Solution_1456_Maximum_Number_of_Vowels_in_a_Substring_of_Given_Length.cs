namespace Solutions.Medium.SlidingWindow;

public class Solution_1456_Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length
{
    public int MaxVowels(string s, int k)
    {
        uint[] vowels = new uint[256];
        vowels['a'] = 1;
        vowels['o'] = 1;
        vowels['e'] = 1;
        vowels['i'] = 1;
        vowels['u'] = 1;

        var maxCount = 0;
        var count = 0;
        
        for (var i = 0; i <= s.Length - k; i++)
        {
            if (i == 0)
            {
                for (var j = 0; j < k; j++)
                    count += (int)vowels[s[j + i]];
            }
            else
            {
                count-= (int)vowels[s[i - 1]];
                count+= (int)vowels[s[i + k - 1]];
            }


            if (count == k) return count;
            if (count > maxCount) maxCount = count;
        }

        return maxCount;
    }

    public int MaxVowels2(string s, int k)
    {
        string vowels = "aoeiu";

        int sLen = s.Length;
        int mCount = 0, count = 0;

        for (int i = 0; i < k; i++)
        {
            if (vowels.IndexOf(s[i]) > -1)
            {
                count++;
            }
        }

        mCount = count;

        for (int i = k; i < sLen; i++)
        {
            if (vowels.IndexOf(s[i - k]) > -1)
            {
                count--;
            }

            if (vowels.IndexOf(s[i]) > -1)
            {
                count++;
            }

            if (count > mCount)
            {
                mCount = count;
            }
        }

        return mCount;
    }
}