/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SortList(ListNode head) {
        if (head == null) {
            return head;
        }
        
        var len = 0;
        var p = head;
        while (p != null) {
            p = p.next;
            len++;
        }
        
        
        return MergeSort(head, len);
    }
    
    private ListNode MergeSort(ListNode head, int len) {
        if (len == 1) {
            head.next = null;
            return head;
        }
        
        var mid = head;
        for (var i = 0; i < len / 2; i++) {
            mid = mid.next;
        }
        
        var p1 = MergeSort(head, len / 2);
        var p2 = MergeSort(mid, len - len / 2);
        
        return Merge(p1, p2);
    }
    
    private ListNode Merge(ListNode p1, ListNode p2) {
        var head = new ListNode(-1);
        var p = head;
        while (p1 != null && p2 != null) {
            if (p1.val < p2.val) {
                p.next = p1;
                p1 = p1.next;
            } else {
                p.next = p2;
                p2 = p2.next;
            }
            p = p.next;
        }
        p.next = (p1 == null ? p2 : p1);
        
        p = head;
        head = head.next;
        p.next = null;
        
        return head;
    }
}
