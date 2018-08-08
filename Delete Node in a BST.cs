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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if (root == null) {
            return null;
        }
        
        if (root.val > key) {
            root.left = DeleteNode(root.left, key);
        } else if (root.val < key) {
            root.right = DeleteNode(root.right, key);
        } else {
            root = DeleteNode(root);
        }
        
        return root;
    }
    
    private TreeNode DeleteNode(TreeNode root) {
        if (root.left != null && root.right != null) 
        {
            var temp = root.right;
            while (temp.left != null) {
                temp = temp.left;
            }
            root.val = temp.val;
            root.right = DeleteNode(root.right, root.val);
            return root;
        }
        
        return root.left != null ? root.left : root.right;
    }
}
