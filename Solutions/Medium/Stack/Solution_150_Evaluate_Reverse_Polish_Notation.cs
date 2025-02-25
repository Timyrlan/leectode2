namespace Solutions.Medium.Stack;

public class Solution_150_Evaluate_Reverse_Polish_Notation
{
    private readonly string operations = "+-*/";

    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<object>();

        foreach (var token in tokens)
            if (!IsOperation(token))
                stack.Push(token);
            else
            {
                int r;
                var token2 = GetIntVal(stack.Pop());
                var token1 = GetIntVal(stack.Pop());

                switch (token)
                {
                    case "*": r = token1 * token2; break;
                    case "/": r = token1 / token2; break;
                    case "+": r = token1 + token2; break;
                    case "-": r = token1 - token2; break;
                    default: throw new InvalidOperationException(token);
                }

                stack.Push(r.ToString());
            }

        return GetIntVal(stack.Pop());
    }

    private int GetIntVal(object token1obj)
    {
        if (token1obj is int obj1) return obj1;

        return int.Parse((token1obj as string)!);
    }

    private bool IsOperation(string token)
    {
        return token.Length == 1 && operations.IndexOf(token[0]) >= 0;
    }
}