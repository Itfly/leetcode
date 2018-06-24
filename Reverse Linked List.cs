/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null) {
            return null;
        }
        
        var pre = head;
        while (pre.next != null) {
            var tmp = pre.next;
            pre.next = tmp.next;
            tmp.next = head;
            head = tmp;
        }
        
        return head;
    }
}
