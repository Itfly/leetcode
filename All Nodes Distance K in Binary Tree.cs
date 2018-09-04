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
    public IList<int> DistanceK(TreeNode root, TreeNode target, int K) {
        var map = new Dictionary<TreeNode, TreeNode>();
        map[root] = null;
        GenParentMap(root, map);
        var result = new List<int>();
        DFS(target, K, map, result);
        
        return result;
    }
    
    private void GenParentMap(TreeNode root, Dictionary<TreeNode, TreeNode> map) {
        if (root.left != null) {
            map[root.left] = root;
            GenParentMap(root.left, map);
        }
        if (root.right != null) {
            map[root.right] = root;
            GenParentMap(root.right, map);
        }
    }
    
    private void DFS(TreeNode node, int k, Dictionary<TreeNode, TreeNode> map, IList<int> result) {
        if (!map.ContainsKey(node)) {
            return;
        }
        
        var parent = map[node];
        map.Remove(node); 
        
        if (k == 0) {
            result.Add(node.val);
            return;
        }
     
        if (node.left != null) {
            DFS(node.left, k - 1, map, result);
        }
        if (node.right != null) {
            DFS(node.right, k - 1, map, result);
        }
        if (parent != null) {
            DFS(parent, k - 1, map, result);
        }
    }
}
