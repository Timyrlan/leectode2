using System.Text;

namespace Solutions.Medium.Stack;

public class Solution_394_Decode_String
{
    public string DecodeString(string s)
    {
        var stack = new Stack<char>();
        var c = -1;
        while (c < s.Length - 1)
        {
            c++;
            if (s[c] != ']')
                stack.Push(s[c]);
            else
            {
                var curText = string.Empty;
                var tmp = stack.Pop();
                while (tmp != '[')
                {
                    curText += tmp;
                    tmp = stack.Pop();
                }


                var curNum = "";
                while (stack.Any() && "1234567890".IndexOf(stack.Peek()) >= 0)
                {
                    tmp = stack.Pop();
                    curNum += tmp;
                }

                var mult = int.Parse(new string(curNum.Reverse().ToArray()));
                var str = new string(curText.Reverse().ToArray());

                var sb = new StringBuilder();
                for (var i = 0; i < mult; i++) sb.Append(str);

                var result = sb.ToString();

                foreach (var cc in result) stack.Push(cc);
            }
        }

        var r = new string(stack.Reverse().ToArray());
        return r;
    }
}