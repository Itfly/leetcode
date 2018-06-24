/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if (head == null || head.next == null || head.next.next == null) {
            return head;
        }
        
        var p1 = head;
        var p2 = head.next;
        var p3 = head.next.next;
        var head2 = p2;
        while (p3 != null) {
            p1.next = p3;
            p2.next = p3.next;
            p3 = p3.next?.next;
            p1 = p1.next;
            p2 = p2.next;
        }
        p1.next = head2;
        
        return head;
    }
}
