public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if (amount == 0) {
            return 0;
        }
        if (coins == null || coins.Length == 0) {
            return -1;
        }
        
        var dp = new int[amount + 1];
        dp[0] = 0;
        for (var i = 1; i <= amount; i++) {
            dp[i] = amount + 1;
        }
        
        for (var i = 1; i <= amount; i++) {
            foreach (var coin in coins) {
                if (coin <= i) {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }
        
        return dp[amount] <= amount ? dp[amount] : -1;
    }
}
