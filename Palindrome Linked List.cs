/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    private ListNode left;
    
    
    public bool IsPalindrome(ListNode head) {
        left = head;
        
        return IsPalindromeHelper(head);
    }
    
    private bool IsPalindromeHelper(ListNode right) {
        if (right == null) {
            return true;
        }
        
        var isPal = IsPalindromeHelper(right.next);
        if (isPal == false) {
            return false;
        }
        
        isPal = (right.val == left.val);
        left = left.next;
        
        return isPal;
    }
}
