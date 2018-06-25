/**
 * Definition for singly-linked list with a random pointer.
 * public class RandomListNode {
 *     public int label;
 *     public RandomListNode next, random;
 *     public RandomListNode(int x) { this.label = x; }
 * };
 */
public class Solution {
    public RandomListNode CopyRandomList(RandomListNode head) {
        if (head == null) {
            return null;
        }
        
        var p = head;
        while (p != null) {
            var copy = new RandomListNode(p.label);
            copy.next = p.next;
            p.next = copy;
            p = copy.next;
        }
        
        p = head;
        while (p != null) {
            if (p.random != null) {
                p.next.random = p.random.next;
            }
            p = p.next.next;
        }
        
        p = head;
        var nh = head.next;
        while (p != null) {
            var tmp = p.next;
            p.next = tmp.next;
            if (tmp.next != null) {
                tmp.next = tmp.next.next;
            }
            p = p.next;
        }
        
        return nh;
    }
}
