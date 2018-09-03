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
    public int DiameterOfBinaryTree(TreeNode root) {
        var (diameter, maxLen) = DiameterAndMaxLength(root);
        return diameter == 0 ? 0 : diameter - 1;
    }
    
    private (int, int) DiameterAndMaxLength(TreeNode root) {
        if (root == null) {
            return (0, 0);
        }
        
        var (diameterL, maxLenL) = DiameterAndMaxLength(root.left);
        var (diameterR, maxLenR) = DiameterAndMaxLength(root.right);
        var maxLen = Math.Max(maxLenL, maxLenR) + 1;
        var diameter = Math.Max(Math.Max(diameterL, diameterR), maxLenL + maxLenR + 1);
        
        return (diameter, maxLen);
    }
}
