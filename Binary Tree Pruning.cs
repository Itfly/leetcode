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
    public TreeNode PruneTree(TreeNode root) {
        return ShouldRemove(root) ? null : root;
    }
    
    private bool ShouldRemove(TreeNode root) {
        var removed = true;
        if (root.left != null) {
            if (ShouldRemove(root.left)) {
                root.left = null;
            } else {
                removed = false;
            }
        }
        
        if (root.right != null) {
            if (ShouldRemove(root.right)) {
                root.right = null;
            } else {
                removed = false;
            }
        }
        
        return removed && root.val != 1;
    }
}
