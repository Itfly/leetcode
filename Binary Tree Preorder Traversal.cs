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
    public IList<int> PreorderTraversal(TreeNode root) {
        var sequence = new List<int>();
        if (root == null) {
            return sequence;
        }
        
        var stack = new Stack<TreeNode>();

        
        while (true) {
            while (root != null) {
                stack.Push(root);
                sequence.Add(root.val);
                root = root.left;
            }
            
            if (stack.Count == 0) {
                break;
            }
            
            root = stack.Pop();
            root = root.right;
        }
        
        return sequence;
    }
}
