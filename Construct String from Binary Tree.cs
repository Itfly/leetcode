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
    public string Tree2str(TreeNode t) {
        if (t == null) {
            return "";
        }
        
        var result = t.val.ToString();
        if (t.left != null) {
            result += "(" + Tree2str(t.left) + ")";
        }
        if (t.right != null) {
            if (t.left == null) {
                result += "()";
            }
            result += "(" + Tree2str(t.right) + ")";
        }
        
        return result;
    }
}
