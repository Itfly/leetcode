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
    public int MaxPathSum(TreeNode root) {
        var curMax = 0;
        return MaxPathSum(root, out curMax);
    }
    
    private int MaxPathSum(TreeNode root, out int curMax) {
        if (root == null) {
            curMax = 0;
            return int.MinValue;
        }
        
        var leftMax = 0;
        var rightMax = 0;
        var maxSum = Math.Max(MaxPathSum(root.left, out leftMax), MaxPathSum(root.right, out rightMax));
        curMax = Math.Max(Math.Max(leftMax, rightMax), 0) + root.val;
        
        return Math.Max(maxSum, Math.Max(curMax, leftMax + rightMax + root.val));
    }
}
