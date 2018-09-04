public class Solution {
// dp(i, k) = max(average(i, N), max_{j > i}(average(i, j) + dp(j, k-1)))
    public double LargestSumOfAverages(int[] A, int K) {
        var n = A.Length;
        var sum = new int[n + 1];
        for (var i = 0; i < n; i++) {
            sum[i + 1] = sum[i] + A[i];
        }
        
        var dp = new double[n];
        for (var i = 0; i < n; i++) {
            dp[i] = (double) (sum[n] - sum[i]) / (n - i);
        }
        
        for (var k = 2; k <= K; k++) {
            for (var i = 0; i < n; i++) {
                for (var j = i + 1; j < n; j++) {
                    dp[i] = Math.Max(dp[i], (double) (sum[j] - sum[i]) / (j - i) + dp[j]);
                }
            }
        }
        
        return dp[0];
    }
}
