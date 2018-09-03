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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        if (root1 == null && root2 == null) {
            return true;
        } else if (root1 == null || root2 == null) {
            return false;
        }
        
        var result1 = GetLeaves(root1);
        var result2 = GetLeaves(root2);
        return result1.SequenceEqual(result2);
    }
    
    private IList<int> GetLeaves(TreeNode root) {
        var result = new List<int>();
        var q = root;
        var stack = new Stack<TreeNode>();
        stack.Push(q);
        while (stack.Count > 0) {
            q = stack.Pop();
            if (q.left == null && q.right == null) {
                result.Add(q.val);
            } else {               
                if (q.right != null) {
                    stack.Push(q.right);
                }
                if (q.left != null) {
                    stack.Push(q.left);
                }
            }
        }
        
        return result;
    }
}
