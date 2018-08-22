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
    public void RecoverTree(TreeNode root) {
        var p = root;
        TreeNode pre = null;
        TreeNode p1 = null;
        TreeNode p2 = null;
        while (p != null) {
            var q = p.left;
            if (q != null) {
                while (q.right != null && q.right != p) {
                    q = q.right;
                }
                if (q.right == null) {
                    q.right = p;
                    p = p.left;
                    continue;
                } else {
                    q.right = null;
                }
            }
                
            if (pre != null && pre.val > p.val) {
                if (p1 == null) {
                    p1 = pre;
                    findFirst = true;
                }
                p2 = p;
            }
            pre = p;
            p = p.right;
        }
                
        var temp = p1.val;
        p1.val = p2.val;
        p2.val = temp;
    }
}
