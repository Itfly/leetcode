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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        var stack = new Stack<TreeNode>();
        foreach (var num in nums) {
            var node = new TreeNode(num);
            while (stack.Count > 0 && stack.Peek().val < num) {
                node.left = stack.Pop();
            }
            
            if (stack.Count > 0) {
                stack.Peek().right = node;
            }
            
            stack.Push(node);
        }
        
        TreeNode root = null;
        while (stack.Count > 0) {
            root = stack.Pop();
        }
        
        return root;
    }
}
