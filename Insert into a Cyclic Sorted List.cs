/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;

    public Node(){}
    public Node(int _val,Node _next) {
        val = _val;
        next = _next;
}
*/
public class Solution {
    public Node Insert(Node head, int insertVal) {
        if (head == null) {
            head = new Node(insertVal, null);
            head.next = head;
            return head;
        }
        
        if (head.next == head) {
            head.next = new Node(insertVal, head);
            return head;
        }
        
        var node = head;
        while (true) {
            if (node.val < node.next.val) {
                if (node.val <= insertVal && insertVal <= node.next.val) {
                    node.next = new Node(insertVal, node.next);
                    break;
                }
            } else if (node.val > node.next.val) {
                if (insertVal >= node.val || insertVal <= node.next.val) {
                    node.next = new Node(insertVal, node.next);
                    break;
                }
            } else {
                if (node.next == head) {
                    node.next = new Node(insertVal, node.next);
                    break;
                }
            }
            node = node.next;
            
        }
        
        return head;
    }
}

