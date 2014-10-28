class Solution {
public:
    int minDistance(string word1, string word2) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int m = word1.length();
        int n = word2.length();
        if (m == 0) return n;
        else if (n == 0) return m;
        
        vector<vector<int> > dp(m+1, vector<int>(n+1));
        
        for (int i = 0; i <= m; i++) {
            dp[i][0] = i;
        }
        for (int i = 1; i <= n; i++) {
            dp[0][i] = i;
        }
        
        for (int i = 1; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
                int tmp = (word1[i-1] == word2[j-1] ? 0 : 1);
                dp[i][j] = min(dp[i-1][j-1] + tmp, min(dp[i-1][j] + 1, dp[i][j-1] + 1));
            }
        }
        
        return dp[m][n];
    }
};