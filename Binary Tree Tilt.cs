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
    public int FindTilt(TreeNode root) {
        var (tilt, sum) = FindTiltAndSum(root);
        return tilt;
    }
    
    private (int, int) FindTiltAndSum(TreeNode root) {
        if (root == null) {
            return (0, 0);
        }
        
        var (tiltL, sumL) = FindTiltAndSum(root.left);
        var (tiltR, sumR) = FindTiltAndSum(root.right);
        
        var sum = sumL + sumR + root.val;
        var tilt = tiltL + tiltR + Math.Abs(sumL - sumR);
        return (tilt, sum);
    }
}
