using System.Text;

namespace Solutions;

public class Solution_1071_Greatest_Common_Divisor_of_Strings
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str2.Length > str1.Length) (str2, str1) = (str1, str2);

        if (Dv(str1, str2)) return str2;

        var window = (int)Math.Floor(str2.Length / 2d);

        while (window > 0)
        {
            for (var i = 0; i < str2.Length - window; i++)
            {
                var s = str2.Substring(i, window);
                if (Dv(str1, s) && Dv(str2, s)) return s;
            }

            window--;
        }

        return string.Empty;
    }

    private bool Dv(string str1, string str2)
    {
        if (str1.Length % str2.Length != 0) return false;

        var sb = new StringBuilder();

        for (var i = 0; i < str1.Length / str2.Length; i++) sb.Append(str2);

        return str1 == sb.ToString();
    }
}