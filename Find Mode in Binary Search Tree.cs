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
    private TreeNode prev;
    private int count = 0;
    private int maxCnt = 0;
    
    public int[] FindMode(TreeNode root) {
        if (root == null) {
            return new int[0];
        }
        
        var result = new List<int>();
        InorderTraverse(root, result);
        
        return result.ToArray();
    }
    
    private void InorderTraverse(TreeNode root, IList<int> result) {
        if (root == null) {
            return;
        }
        
        InorderTraverse(root.left, result);
        
        if (prev != null && root.val == prev.val) {
            count++;    
        } else {
            count = 1;
        }
        
        if (count > maxCnt) {
            maxCnt = count;
            result.Clear();
            result.Add(root.val);
        } else if (count == maxCnt){
            result.Add(root.val);
        }
        
        prev = root;
        InorderTraverse(root.right, result);
    }
}

 
public class Solution {    
    public int[] FindMode(TreeNode root) {
        if (root == null) {
            return new int[0];
        }
        
        var result = new List<int>();
        var count = 0;
        var maxCnt = 0;
        var cur = root;
        TreeNode prev = null;
        while (cur != null) {
            if (cur.left != null) {
                TreeNode q = cur.left;
                while (q.right != null && q.right != cur) {
                    q = q.right;
                }
                
                if (q.right == null) {
                    q.right = cur;
                    cur = cur.left;
                } else {
                    q.right = null;
                    HandleNode(cur,  prev, ref maxCnt, ref count, result);
                    prev = cur;
                    cur = cur.right;
                }
            } else {
                HandleNode(cur,  prev, ref maxCnt, ref count, result);
                prev = cur;
                cur = cur.right;
            }
        }
        
        
        
        return result.ToArray();
    }
    
    private void HandleNode(TreeNode cur,  TreeNode prev, ref int maxCnt, ref int count, IList<int> result) {
        if (prev != null && cur.val == prev.val) {
            count++;    
        } else {
            count = 1;
        }
        
        if (count > maxCnt) {
            maxCnt = count;
            result.Clear();
            result.Add(cur.val);
        } else if (count == maxCnt){
            result.Add(cur.val);
        }    
    }
}
