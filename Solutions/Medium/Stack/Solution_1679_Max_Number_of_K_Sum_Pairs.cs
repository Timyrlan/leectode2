namespace Solutions.Medium.Stack;

public class Solution_2390_Removing_Stars_From_a_String
{
    public string RemoveStars(string s)
    {
        var stack = new Stack<char>();
        var current = 0;
        while (current < s.Length)
        {
            if (s[current] != '*')
                stack.Push(s[current]);
            else
                stack.Pop();
            current++;
        }

        var result = new string(stack.Reverse().ToArray());
        return result;
    }
}