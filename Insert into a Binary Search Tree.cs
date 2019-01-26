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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if (root == null) {
            return new TreeNode(val);
        }
        
        TreeNode pre = null;
        TreeNode cur = root;
        while (cur != null) {
            if (cur.val == val) {
                break; // never happen
            } else if (cur.val > val) {
                pre = cur;
                cur = cur.left;
            } else {
                pre = cur;
                cur = cur.right;
            }
        }
        if (pre.val > val) {
            pre.left = new TreeNode(val);
        } else {
            pre.right = new TreeNode(val);
        }
        
        return root;
    }
}
