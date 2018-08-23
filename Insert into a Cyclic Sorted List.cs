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

// Not test
    public class Solution
    {
        public ListNode Insert(ListNode node, int x)
        {
            var newNode = new ListNode(x);
            if (node == null)
            {
                newNode.next = newNode;
                return newNode;
            }

            var cur = node.next;
            var pre = node;
            while (cur != node)
            {
                if (pre.val <= x && cur.val >= x)
                {
                    break;
                }

                if (pre.val > cur.val && (pre.val < x || cur.val > x))
                {
                    break;
                }

                pre = cur;
                cur = cur.next;
            }

            pre.next = newNode;
            newNode.next = cur;

            return node;
        }
    }
