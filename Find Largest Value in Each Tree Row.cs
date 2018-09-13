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
    public IList<int> LargestValues(TreeNode root) {
        var result = new List<int>();
        if (root == null) {
            return result;
        }
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            var cnt = queue.Count;
            var value = int.MinValue;
            while (cnt-- > 0) {
                var cur = queue.Dequeue();
                value = Math.Max(value, cur.val);
                
                if (cur.left != null) {
                    queue.Enqueue(cur.left);
                }
                if (cur.right != null) {
                    queue.Enqueue(cur.right);
                }
            }
            
            result.Add(value);
        }
        
        return result;
    }
}
