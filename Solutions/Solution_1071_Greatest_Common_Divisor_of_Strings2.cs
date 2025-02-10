namespace Solutions;

public class Solution_1071_Greatest_Common_Divisor_of_Strings2
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str2.Length > str1.Length) (str2, str1) = (str1, str2);

        if (Dv(str1, str2)) return str2;

        var window = str2.Length - 1;
        while (window > 0)
        {
            if (str1.Length % window == 0 && str2.Length % window == 0)
            {
                var substr = str2.Substring(0, window);
                if (Dv(str1, substr) && Dv(str2, substr)) return substr;
            }

            window--;
        }

        return string.Empty;
    }

    private bool Dv(string strA, string strB)
    {
        
        return string.IsNullOrEmpty(strA.Replace(strB, string.Empty));
    }
}