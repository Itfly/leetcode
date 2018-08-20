public class Solution {
    public int MaxCoins(int[] nums) {
        var temp = new int[nums.Length + 2];
        temp[0] = temp[nums.Length + 1] = 1;
        Array.Copy(nums, 0, temp, 1, nums.Length);
        nums = temp;
        
        var dp = new int[nums.Length, nums.Length];
        for (var i = 1; i < nums.Length - 1; i++) {
            for (var j = i; j >= 1; j--) {
                for (var k = j; k <= i; k++) {
                    dp[j, i] = Math.Max(dp[j, i], nums[j - 1] * nums[k] * nums[i + 1] + dp[j, k - 1] + dp[k + 1, i]);
                }
            }
        }
        
        return dp[1, nums.Length - 2];
    }
}
