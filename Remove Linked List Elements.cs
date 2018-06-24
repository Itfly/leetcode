/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        var pre = new ListNode(-1);
        pre.next = head;
        head = pre;
        
        var p = pre.next;
        while (p != null) {
            if (p.val == val) {
                pre.next = p.next;
                p.next = null;
                p = pre.next;
            } else {
                pre = p;
                p = p.next;
            }
        }
        
        pre = head;
        head = pre.next;
        pre.next = null;
        
        return head; 
    }
}
