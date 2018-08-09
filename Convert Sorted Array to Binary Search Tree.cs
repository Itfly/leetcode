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
    public TreeNode SortedArrayToBST(int[] nums) {
        return SortedArrayToBST(nums, 0, nums.Length - 1);
    }
    
    private TreeNode SortedArrayToBST(int[] nums, int start, int end) {
        if (start > end) {
            return null;
        }
        
        var mid = start + (end - start) / 2;
        var root = new TreeNode(nums[mid]);
        root.left = SortedArrayToBST(nums, start, mid - 1);
        root.right = SortedArrayToBST(nums, mid + 1, end);
        
        return root;
    }
}
