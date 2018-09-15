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
    public IList<TreeNode> AllPossibleFBT(int N) {
        return AllPossibleFBT(N, new Dictionary<int, IList<TreeNode>>());
    }
    
    private IList<TreeNode> AllPossibleFBT(int n, Dictionary<int, IList<TreeNode>> cache) {
        var result = new List<TreeNode>();
        if (n % 2 == 0) {
            return result;
        }
        
        if (cache.ContainsKey(n)) {
            return cache[n];
        }
        if (n == 1) {
            result.Add(new TreeNode(0));
            return result;
        }
        
        n--;
        for (var i = 1; i < n; i += 2) {
            var left = AllPossibleFBT(i, cache);
            var right = AllPossibleFBT(n - i , cache);
            foreach (var n1 in left) {
                foreach (var n2 in right) {
                    var node = new TreeNode(0);
                    node.left = n1;
                    node.right = n2;
                    result.Add(node); 
                }
            }
        }
        
        cache[n] = result;
        return result;
    }
}
