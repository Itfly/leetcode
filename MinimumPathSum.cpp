class Solution {
public:
    int minPathSum(vector<vector<int> > &grid) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int m = grid.size();
        int n = grid[0].size();
        vector<int> dp(n+1, INT_MAX);
        dp[1] = 0;
        
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                dp[j+1] = min(dp[j], dp[j+1]) + grid[i][j];
            }
        }
        return dp[n];
    }
};