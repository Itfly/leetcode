public class Solution {
    // dp[i][j] = (dp[i - 1][j] && s1[i - 1] == s3[i - 1 + j]) || (dp[i][j - 1] && s2[j - 1] == s3[j - 1 + i]);
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s1 == null && s2 == null && s3 == null) {
            return true;
        }
        if (s1 == null || s2 == null || s3 == null) {
            return false;
        }
        if (s1.Length + s2.Length != s3.Length) {
            return false;
        }
        
        var dp = new bool[s1.Length + 1, s2.Length + 2];
        dp[0, 0] = true;
        for (var i = 0; i <= s1.Length; i++) {
            for (var j = 0; j <= s2.Length; j++) {
                if (i == 0 && j == 0) {
                    dp[i, j] = true;
                } else if (i == 0) {
                    dp[i, j] = dp[i, j - 1] && s2[j - 1] == s3[i + j - 1];
                } else if (j == 0) {
                    dp[i, j] = dp[i - 1, j] && s1[i - 1] == s3[i + j - 1];
                } else {
                    dp[i, j] = (dp[i, j - 1] && s2[j - 1] == s3[i + j - 1]) || (dp[i - 1, j] && s1[i - 1] == s3[i + j - 1]);
                }
            }
        }
        
        return dp[s1.Length, s2.Length];
    }
}

// DFS
public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s1 == null && s2 == null && s3 == null) {
            return true;
        }
        if (s1 == null || s2 == null || s3 == null) {
            return false;
        }
        if (s1.Length + s2.Length != s3.Length) {
            return false;
        }
        
        return IsInterleave(s1, 0, s2, 0, s3, 0, new HashSet<int>());
    }
    
    private bool IsInterleave(string s1, int i, string s2, int j, string s3, int k, HashSet<int> deadEnd) {
        var key = i * s3.Length + j;
        if (deadEnd.Contains(key)) {
            return false;
        }
        
        if (i == s1.Length) {
            return s2.Substring(j) == s3.Substring(k);
        }
        if (j == s2.Length) {
            return s1.Substring(i) == s3.Substring(k);
        }
        
        if (s1[i] == s3[k] && IsInterleave(s1, i + 1, s2, j, s3, k + 1, deadEnd)
           || s2[j] == s3[k] && IsInterleave(s1, i, s2, j + 1, s3, k + 1, deadEnd)) {
            return true;
        }
        
        deadEnd.Add(key);
        return false;
    }
}
