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
public class Solution_2095_Delete_the_Middle_Node_of_a_Linked_List
{
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head?.next == null) return null;


        var slow = head;
        var fast = head.next.next;

        // Let 'fast' move forward by 2 nodes, 'slow' move forward by 1 node each step.
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        slow.next = slow.next.next;

        return head;
    }
}