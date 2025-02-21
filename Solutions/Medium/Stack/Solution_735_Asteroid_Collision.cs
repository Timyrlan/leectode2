namespace Solutions.Medium.Stack;

public class Solution_735_Asteroid_Collision
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();
        var result = new List<int>();
        foreach (var asteroid in asteroids)
        {
            if (asteroid > 0)
            {
                stack.Push(asteroid);
                continue;
            }

            var destroyed = false;
            var asteroid2 = -asteroid;
            while (stack.Any() && !destroyed)
                if (stack.Peek() > asteroid2)
                    destroyed = true;
                else if (stack.Peek() == asteroid2)
                {
                    stack.Pop();
                    destroyed = true;
                }
                else
                    stack.Pop();

            if (!destroyed) result.Add(asteroid);
        }


        result.AddRange(stack.Reverse().ToArray());

        return result.ToArray();
    }
}