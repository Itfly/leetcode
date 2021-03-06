class Solution {
public:
    int uniquePaths(int m, int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<int> dp(n+1,0);
        dp[1] = 1;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                dp[j+1] += dp[j];
            }
        }
        return dp[n];
    }
};