public class Solution {
    public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) {
            return s;
        }
        
        var n = s.Length;
        var maxLen = 0;
        var dp = new bool[n, n];
        var str = "";
        for (var k = 0; k < n; k++) {
            for (var i = 0; i < n - k; i++) {
                var j = i + k;
                if (s[i] == s[j] && (j - i <= 2 || dp[i + 1, j - 1])) {
                    dp[i, j] = true;
                    
                    if (j - i + 1 > maxLen) {
                        maxLen = j - i + 1;
                        str = s.Substring(i, maxLen);
                    }
                }
            }
        }
        
        return str;
    }
}
