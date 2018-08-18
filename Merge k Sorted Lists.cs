/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
class Solution {
    public ListNode mergeKLists(ListNode[] lists) {
        if(lists==null||lists.length==0) {
            return null;
        }
    
        PriorityQueue<ListNode> heap = new PriorityQueue<ListNode>(new Comparator<ListNode>(){
            public int compare(ListNode l1, ListNode l2){
                return l1.val - l2.val;
            }
        });
        for (ListNode list : lists) {
            if (list != null) {
                heap.offer(list);
            }
        }

        ListNode head = new ListNode(-1);
        ListNode p = head;
        while (!heap.isEmpty()) {
            ListNode cur = heap.poll();
            if (cur.next != null) {
                heap.offer(cur.next);
                cur.next = null;
            }
            p.next = cur;
            p = p.next;
        }
        
        return head.next;
    }
}
