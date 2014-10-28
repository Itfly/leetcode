class Solution {
public:
    int numDistinct(string S, string T) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int m = S.length();
        int n = T.length();
        if (m < n || m == 0 || n == 0) return 0;
        
        vector<int> dp(n, 0);
       // dp[0] = S[0] == T[0];
        for (int i = 0; i < m; i++) {
            for (int j = n - 1; j > 0; j--) {
                dp[j] += (S[i] == T[j] ? dp[j-1] : 0);
            }
            dp[0] += (S[i] == T[0] ? 1 : 0);
        }
        return dp[n-1];
    }
};