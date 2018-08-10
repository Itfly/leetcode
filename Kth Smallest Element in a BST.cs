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
    public int KthSmallest(TreeNode root, int k) {
        var stack = new Stack<TreeNode>();
        var cur = root;
        var cnt = 0;
        
        while (cur != null || stack.Count > 0) {
            if (cur != null) {
                stack.Push(cur);
                cur = cur.left;
            } else {
                cur = stack.Pop();
                k--;
                if (k == 0) {
                    return cur.val;
                }
                cur = cur.right;
            }
        }
        
        return -1;
        
    }
}
