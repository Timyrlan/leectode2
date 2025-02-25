namespace Solutions.Medium.Queue;

public class Solution_649_Dota2_Senate
{
    public string PredictPartyVictory(string senate)
    {
        var list = new LinkedList<char>();

        foreach (var s in senate) list.AddLast(s);

        var current = list.First;


        while (list.Count > 0)
        {
            var toRemove = FindFirst(current, list);

            if (toRemove == null)
                return current.Value == 'R' ? "Radiant" : "Dire";

            list.Remove(toRemove);

            current = current.Next ?? list.First;
        }

        return list.First.Value == 'R' ? "Radiant" : "Dire";
    }

    private LinkedListNode<char>? FindFirst(LinkedListNode<char> c, LinkedList<char> list)
    {
        var next = c.Next ?? list.First;
        while (true)
        {
            if (next == c) return null;

            if (next.Value != c.Value) return next;

            next = next.Next ?? list.First;
        }
    }
}