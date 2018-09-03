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
    public int SumOfLeftLeaves(TreeNode root) {
        if (root == null) {
            return 0;
        }
        
        var result = 0;
        var lq = new Queue<TreeNode>();
        var rq = new Queue<TreeNode>();
        rq.Enqueue(root);
        while (lq.Count > 0 || rq.Count > 0) {
            if (lq.Count > 0) {
                var left = lq.Dequeue();
                if (left.left == null && left.right == null) {
                    result += left.val;
                } else {
                    if (left.left != null) {
                        lq.Enqueue(left.left);
                    } 
                    if (left.right != null) {
                        rq.Enqueue(left.right);
                    }
                }
            }
            
            if (rq.Count > 0) {
                var right = rq.Dequeue();
                if (right.left != null) {
                    lq.Enqueue(right.left);
                }
                if (right.right != null) {
                    rq.Enqueue(right.right);
                }
            }
        }
        
        return result;
    }
}
