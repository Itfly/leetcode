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
    public TreeNode ConvertBST(TreeNode root) {
        var sum = 0;
        Convert(root, ref sum);
        
        return root;
    }
    
    private void Convert(TreeNode current, ref int sum) {
        if (current == null) {
            return;
        }
        
        Convert(current.right, ref sum);
        var temp = current.val;
        current.val += sum;
        sum += temp;
        Convert(current.left, ref sum);
    }
}
