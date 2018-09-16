public class Solution {
    public int MinDistance(string word1, string word2) {
        var dp = new int[word1.Length + 1, word2.Length + 1];
        for (var i = 0; i <= word1.Length; i++) {
            dp[i, 0] = 0;
        }
        for (var i = 0; i <= word2.Length; i++) {
            dp[0, i] = 0;
        }
        
        for (var i = 1; i <= word1.Length; i++) {
            for (var j = 1; j <= word2.Length; j++) {
                if (word1[i - 1] == word2[j - 1]) {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                } else {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }
        
        return word1.Length + word2.Length - 2 * dp[word1.Length, word2.Length];
    }
}
