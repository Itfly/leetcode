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
    public int LongestUnivaluePath(TreeNode root) {
        var result = Helper(root);
        return result.Path;
    }
    
    private (int Depth, int Path) Helper(TreeNode root) {
        if (root == null) {
            return (0, 0);
        }
        
        var depth = 0; 
        var path = 0; // path within root node
        var left = Helper(root.left);;
        var right = Helper(root.right);
        
        if (root.left?.val == root.val) {
            depth = Math.Max(depth, left.Depth + 1);
            path = left.Depth + 1; 
        }
        if (root.right?.val == root.val) {
            depth = Math.Max(depth, right.Depth + 1);
            path += right.Depth + 1;
        }
        
        return (depth, Math.Max(path, Math.Max(left.Path, right.Path)));
    }
}
