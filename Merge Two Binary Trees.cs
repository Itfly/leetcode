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
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
        if (t1 == null && t2 == null) {
            return null;
        }
        
        var t = new TreeNode(0);
        if (t1 != null) {
            t.val += t1.val;
        }
        if (t2 != null) {
            t.val += t2.val;
        }
        
        t.left = MergeTrees(t1?.left, t2?.left);
        t.right = MergeTrees(t1?.right, t2?.right);
        
        return t;
    }
}
