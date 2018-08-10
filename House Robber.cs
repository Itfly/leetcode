public class Solution {
    // dp[i] = Math.max(dp[i-1], dp[i-2]+nums[i])
    public int Rob(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        var even = 0;
        var odd = 0;
        for (var i = 0; i < nums.Length; i++) {
            if (i % 2 == 0) {
                even += nums[i];
                even = Math.Max(even, odd);
            } else {
                odd += nums[i];
                odd = Math.Max(even, odd);
            }
        }
        
        return Math.Max(even, odd);
    }
}
