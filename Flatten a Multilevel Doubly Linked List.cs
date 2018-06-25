/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;

    public Node(){}
    public Node(int _val,Node _prev,Node _next,Node _child) {
        val = _val;
        prev = _prev;
        next = _next;
        child = _child;
}
*/
public class Solution {
    public Node Flatten(Node head) {
        var p = head;
        while (p != null) {
            if (p.child != null) {
                var tail = p.child;
                while (tail.next != null) {
                    tail = tail.next;
                }
                
                if (p.next != null) {
                    p.next.prev = tail;
                }
                
                p.child.prev = p;
                tail.next = p.next;
                p.next = p.child;
                p.child = null;
            }
            p = p.next;
        }
        
        return head;
    }
}

