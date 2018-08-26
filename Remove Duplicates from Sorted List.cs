/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head?.next == null) {
            return head;
        }
        
        var p = head;
        
        while (p != null) {
            var q = p.next;
            while (p.val == q?.val) {
                q = q.next;
            }
            if (p.next != q) {
                p.next = q;
            }
            p = q;
        }
        
        return head;
    }
}
