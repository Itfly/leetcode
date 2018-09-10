public class Solution {
    public bool Find132pattern(int[] nums) {
        var third = int.MinValue;
        var n = nums.Length;
        var j = n;
        for (var i = n - 1; i >= 0; i--) {
            if (nums[i] < third) {
                return true;
            }
            
            while (j < n && nums[i] > nums[j]) {
                third = nums[j++];
            }
            nums[--j] = nums[i];
        }
        
        return false;
    }
}

//https://leetcode.com/problems/132-pattern/discuss/94089/Java-solutions-from-O(n3)-to-O(n)-for-%22132%22-pattern-(updated-with-one-pass-slution)
