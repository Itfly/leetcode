/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (head == null || k == 1) {
            return head;
        }
        
        var prev = new ListNode(-1);
        prev.next = head;
        var p = head;
        head = prev;
        var i = 0;
        while (p != null) {
            i++;
            if (i % k == 0) {
                prev = Reverse(prev, p.next);
                p = prev.next;
            } else {
                p = p.next;
            }
        }
        
        return head.next;
    }
    
    private ListNode Reverse(ListNode prev, ListNode end) {
        var p = prev.next;
        var q = p.next;
        while (q != end) {
            p.next = q.next;
            q.next = prev.next;
            prev.next = q;
            q = p.next;
        }
        return p;
    }
}
