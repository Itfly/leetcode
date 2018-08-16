public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var wordSet = new HashSet<string>(wordDict);
        var dp = new bool[s.Length + 1];
        dp[0] = true;
        for (var i = 0; i < s.Length; i++) {
            if (!dp[i]) {
                continue;
            }
            for (var j = i + 1; j <= s.Length; j++) {
                var sub = s.Substring(i, j - i);
                if (wordSet.Contains(sub)) {
                    dp[j] = true;
                }
            }
        }
        
        return dp[s.Length];
    }
}
