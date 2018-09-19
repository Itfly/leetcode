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
    public int[] FindFrequentTreeSum(TreeNode root) {
        var result = new List<int>();
        var map = new Dictionary<int, int>();
        var maxCount = 0;
        Traverse(root, map, ref maxCount);
        foreach (var entity in map) {
            if (entity.Value == maxCount) {
                result.Add(entity.Key);
            }
        }
        
        return result.ToArray();
    }
    
    private int Traverse(TreeNode root, Dictionary<int, int> map, ref int maxCount) {
        if (root == null) {
            return 0;
        }
        
        var sum = root.val;
        sum += Traverse(root.left, map, ref maxCount);
        sum += Traverse(root.right, map, ref maxCount);
        
        if (map.ContainsKey(sum)) {
            map[sum]++;
        } else {
            map[sum] = 1;
        }
        
        maxCount = Math.Max(maxCount, map[sum]);
        
        return sum;
    }
}
