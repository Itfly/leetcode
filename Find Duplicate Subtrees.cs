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
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
        var dups = new List<TreeNode>();
        var map = new Dictionary<string, int>();
        Helper(root, map, dups);
        
        return dups;
    }
    
    private string Helper(TreeNode root, Dictionary<string, int> map, List<TreeNode> dups) {
        if (root == null) {
            return "#";
        }
        var str = Helper(root.left, map, dups) + "," + root.val + "," + Helper(root.right, map, dups) + ",";
        if (map.ContainsKey(str)) {
            if (map[str] == 1) {
                dups.Add(root);
            }
            ++map[str];
        } else {
            map[str] = 1;
        }
        
        
        return str;
    }
}
