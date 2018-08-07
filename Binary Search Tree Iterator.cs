/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class BSTIterator {
    private Stack<TreeNode> stack;
    
    public BSTIterator(TreeNode root) {
        stack = new Stack<TreeNode>();
        PushLeft(root);
    }

    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return stack.Count > 0;
    }

    /** @return the next smallest number */
    public int Next() {
        var node = stack.Pop();
        if (node.right != null) {
            PushLeft(node.right);
        }
        
        return node.val;
    }
    
    private void PushLeft(TreeNode node) {
        while (node != null) {
            stack.Push(node);
            node = node.left;
        }
    }
}

/**
 * Your BSTIterator will be called like this:
 * BSTIterator i = new BSTIterator(root);
 * while (i.HasNext()) v[f()] = i.Next();
 */
