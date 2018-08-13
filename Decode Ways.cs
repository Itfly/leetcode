public class Solution {
    public int NumDecodings(string s) {
        if (string.IsNullOrEmpty(s) || s[0] == '0') {
            return 0;
        }
        if (s.Length == 1) {
            return 1;
        }
        
        var dp = new int[s.Length];
        dp[0] = 1;
        
        for (var i = 1; i < s.Length; i++) {
            if (s[i] != '0') {
                dp[i] = dp[i - 1];
            } else {
                dp[i] = 0;
            }
            if (s[i - 1] == '1' || s[i - 1] == '2' && s[i] <= '6') {
                dp[i] += (i == 1 ? 1 : dp[i - 2]);
            }
            
            if (dp[i] == 0) {
                return 0;
            }
        }
        
        return dp[s.Length - 1];
    }
}
