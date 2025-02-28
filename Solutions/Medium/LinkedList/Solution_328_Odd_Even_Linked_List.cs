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
public class Solution_328_Odd_Even_Linked_List
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head?.next == null) return head;

        var secondHead = head.next;

        var current = head;


        while (current?.next != null)
        {
            var a = current.next;
            var b = a?.next;
            var c = b?.next;

            if (a != null) a.next = c;

            current.next = b;

            if (b != null) current = b;
        }

        current.next = secondHead;

        return head;
    }
}