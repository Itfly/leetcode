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
        var n1 = GetLength(l1);
        var n2 = GetLength(l2);
        
        var head = new ListNode(1);
        head.next = (n1 > n2 ? AddTwoNumbers(l1, l2, n1 - n2) : AddTwoNumbers(l2, l1, n2 - n1));
        
        if (head.next.val > 9) {
            head.next.val %= 10;
            return head;
        } 
        
        return head.next;
    }
    
    private int GetLength(ListNode l) {
        var cnt = 0;
        while (l != null) {
            l = l.next;
            cnt++;
        }
        
        return cnt;
    }
    
    private ListNode AddTwoNumbers(ListNode l1, ListNode l2, int offset) {
        if (l1 == null) {
            return null;
        }
        
        var current = (offset == 0 ? new ListNode(l1.val + l2.val) : new ListNode(l1.val));
        var next = (offset == 0 ? AddTwoNumbers(l1.next, l2.next, 0) : AddTwoNumbers(l1.next, l2, offset - 1));
        if (next != null && next.val > 9) {
            next.val %= 10;
            current.val++;
        }
        current.next = next;
        
        return current;
    }
}


// Or else use the below method: align at position, add l1,l2 to l with reverse link, then revese the link and deal with the carry.
// https://leetcode.com/problems/add-two-numbers-ii/discuss/92788/Java-iterative-O(1)-space-lastNot9-solution-Changed-from-Plus-One-Linked-List
