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
    public bool IsBalanced(TreeNode root) {
        int depth;
        return IsBalanced(root, out depth);
    }
    
    private bool IsBalanced(TreeNode root, out int depth) {
        if (root == null) {
            depth = 0;
            return true;
        }
        
        int left;
        int right;
        if (!IsBalanced(root.left, out left) || !IsBalanced(root.right, out right)) {
            depth = 0; // No sense
            return false;
        }
        
        depth = Math.Max(left, right) + 1;
        return Math.Abs(left - right) <= 1;
    }
}
