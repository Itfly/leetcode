/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if (l1 == null) {
            return l2;
        }  
        if (l2 == null) {
            return l1;
        }
        
        var carry = 0;
        var head = new ListNode(-1);
        var pre = head;
        while (l1 != null && l2 != null) {
            var sum = l1.val + l2.val + carry;
            carry = sum / 10;
            var cur = new ListNode(sum%10);
            pre.next = cur;
            pre = cur;
            
            l1 = l1.next;
            l2 = l2.next;
        }
        
        if (l2 != null) {
            l1 = l2;
        }
        
        while (l1 != null) {
            var sum = l1.val + carry;
            carry = sum / 10;
            var cur = new ListNode(sum%10);
            pre.next = cur;
            pre = cur;
            
            l1 = l1.next;
        }
        
        if (carry == 1) {
            var cur = new ListNode(1);
            pre.next = cur;
        }

        return head.next;
    }
}




