namespace Solutions.Medium.LinkedList;

public class Test
{
    [TestCase(new[] { 1, 3, 4, 1, 2, 6 }, new[] { 1, 3, 4, 7, 1, 2, 6 })]
    [TestCase(new[] { 1, 2, 4 }, new[] { 1, 2, 3, 4 })]
    [TestCase(new[] { 2 }, new[] { 2, 1 })]
    public void Solution_2390_Removing_Stars_From_a_String(int[] expected, int[] s)
    {
        var current = new ListNode(s[^1]);

        for (var i = s.Length - 2; i >= 0; i--) current = new ListNode(s[i], current);

        var result = new Solution_2095_Delete_the_Middle_Node_of_a_Linked_List().DeleteMiddle(current);

        var items = new List<int>();
        current = result;

        while (current != null)
        {
            items.Add(current.val);
            current = current.next;
        }

        var actual = items.ToArray();

        Assert.That(actual, Is.EqualTo(expected));
    }


    [TestCase(new[] { 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [TestCase(new[] { 4, 5, 6 }, new[] { 1, 2, 3, 4, 5, 6 })]
    public void Solution_876_Middle_of_the_Linked_List(int[] expected, int[] s)
    {
        var current = new ListNode(s[^1]);

        for (var i = s.Length - 2; i >= 0; i--) current = new ListNode(s[i], current);

        var result = new Solution_876_Middle_of_the_Linked_List().MiddleNode(current);

        var items = new List<int>();
        current = result;

        while (current != null)
        {
            items.Add(current.val);
            current = current.next;
        }

        var actual = items.ToArray();

        Assert.That(actual, Is.EqualTo(expected));
    }


    [TestCase(new[] { 1, 3, 5, 2, 4 }, new[] { 1, 2, 3, 4, 5 })]
    [TestCase(new[] { 2, 3, 6, 7, 1, 5, 4 }, new[] { 2, 1, 3, 5, 6, 4, 7 })]
    [TestCase(new[] { 1, 3, 5, 7, 2, 4,6,8 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
    public void Solution_328_Odd_Even_Linked_List(int[] expected, int[] s)
    {
        var current = new ListNode(s[^1]);

        for (var i = s.Length - 2; i >= 0; i--) current = new ListNode(s[i], current);

        var result = new Solution_328_Odd_Even_Linked_List().OddEvenList(current);

        var items = new List<int>();
        current = result;

        while (current != null)
        {
            items.Add(current.val);
            current = current.next;
        }

        var actual = items.ToArray();

        Assert.That(actual, Is.EqualTo(expected));
    }


    [TestCase(new[] { 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5 })]
    public void Solution_206_Reverse_Linked_List(int[] expected, int[] s)
    {
        var current = new ListNode(s[^1]);

        for (var i = s.Length - 2; i >= 0; i--) current = new ListNode(s[i], current);

        var result = new Solution_206_Reverse_Linked_List().ReverseList(current);

        var items = new List<int>();
        current = result;

        while (current != null)
        {
            items.Add(current.val);
            current = current.next;
        }

        var actual = items.ToArray();

        Assert.That(actual, Is.EqualTo(expected));
    }
    
    
    [TestCase(6, new[] { 5, 4, 2, 1 })]
    [TestCase(7, new[] { 4, 2, 2, 3 })]
    [TestCase(182, new[] { 47, 22, 81, 46, 94, 95, 90, 22, 55, 91, 6, 83, 49, 65, 10, 32, 41, 26, 83, 99, 14, 85, 42, 99, 89, 69, 30, 92, 32, 74, 9, 81, 5, 9 })]
    public void Solution_2130_Maximum_Twin_Sum_of_a_Linked_List(int expected, int[] s)
    {
        var current = new ListNode(s[^1]);

        for (var i = s.Length - 2; i >= 0; i--) current = new ListNode(s[i], current);

        var result = new Solution_2130_Maximum_Twin_Sum_of_a_Linked_List().PairSum(current);


        Assert.That(result, Is.EqualTo(expected));
    }
}

public class ListNode(int val = 0, ListNode next = null)
{
    public ListNode? next = next;
    public int val = val;
}
