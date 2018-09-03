public class Solution {
    public int Change(int amount, int[] coins) {
        if (amount == 0) {
            return 1;
        }
        if (coins == null || coins.Length == 0) {
            return 0;
        }
        
        var dp = new int[amount + 1];
        dp[0] = 1;
        foreach (var coin in coins) {
            for (var i = coin; i <= amount; i++) {
                dp[i] += dp[i - coin];
            }
        }
        
        /* This would cause repetition: 3 = 1 + 2, 2 + 1
        for (var i = 1; i <= amount; i++) {
            foreach (var coin in coins) {
                if (coin <= i) {
                    dp[i] += dp[i - coin];
                }
            }
        }*/
        
        return dp[amount];
    }
}
