/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public int FindBottomLeftValue(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            root = queue.Dequeue();
            if (root.right != null) {
                queue.Enqueue(root.right);
            }
            if (root.left != null) {
                queue.Enqueue(root.left);
            }
        }
        
        return root.val;
    }
}

/*
public class Solution {
    public int FindBottomLeftValue(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var result = root.val;
        while (queue.Count > 0) {
            var size = queue.Count;
            result = queue.Peek().val;
            while (size-- > 0) {
                var cur = queue.Dequeue();
                if (cur.left != null) {
                    queue.Enqueue(cur.left);
                }
                if (cur.right != null) {
                    queue.Enqueue(cur.right);
                }
            }
        }
        
        return result;
    }
}
*/
