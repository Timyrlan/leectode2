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
public class Solution_206_Reverse_Linked_List
{
    public ListNode ReverseList(ListNode head)
    {
        if (head?.next == null) return head;


        var current = head;
        var next = head.next;
        while (next != null)
        {
            var next2 = next.next;
            next.next = current;
            current = next;
            next = next2;
        }

        head.next = null;

        return current;
    }
}