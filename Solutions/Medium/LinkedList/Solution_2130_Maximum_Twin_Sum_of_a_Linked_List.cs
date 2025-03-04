namespace Solutions.Medium.LinkedList;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 * public int val;
 * public ListNode next;
 * public ListNode(int val=0, ListNode next=null) {
 * this.val = val;
 * this.next = next;
 * }
 * }
 */
public class Solution_2130_Maximum_Twin_Sum_of_a_Linked_List
{
    public int PairSum(ListNode head)
    {
        var result = new List<int> { head.val };

        while (head.next != null)
        {
            head = head.next;
            result.Add(head.val);
        }

        var max = int.MinValue;

        for (var i = 0; i < result.Count / 2; i++)
        {
            var sum = result[i] + result[^(i+1)];
            if (sum > max) max = sum;
        }

        return max;
    }
}