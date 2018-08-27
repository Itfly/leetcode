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
    public int GetMinimumDifference(TreeNode root) {
        var result = int.MaxValue;
        var prev = -1;
        Inorder(root, ref prev, ref result);
        
        return result;
    }
    
    private void Inorder(TreeNode root, ref int prev, ref int result) {
        if (root == null) {
            return;
        }
        
        Inorder(root.left, ref prev, ref result);
        if (prev != -1) {
            result = Math.Min(result, root.val -prev);
        }
        prev = root.val;
        Inorder(root.right, ref prev, ref result);
    }
}

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
    public int GetMinimumDifference(TreeNode root) {
        var result = int.MaxValue;
        TreeNode prev = null;
        var stack = new Stack<TreeNode>();
        var p = root;
        while (p != null || stack.Count > 0) {
            if (p != null) {
                stack.Push(p);
                p = p.left;
            } else {
                p = stack.Pop();
                if (prev != null) {
                    result = Math.Min(result, p.val - prev.val);
                }
                prev = p;
                p = p.right;
            }
        }
        
        return result;
    }
}
