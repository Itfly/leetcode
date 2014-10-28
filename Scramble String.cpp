class Solution {
public:
    bool isScramble(string s1, string s2) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int m = s1.length();
        int n = s2.length();
        if (m != n) return false;
        
        vector<vector<vector<int > > > dp(m+1, vector<vector<int> >(m, vector<int>(m)));
        
        for (int i = 0; i < m; i++) 
            for (int j = 0; j < m; j++) {
                dp[1][i][j] = (s1[i] == s2[j]); 
            }
        
        for (int l = 2; l <= m; l++) {
            for (int i = 0; i <= m - l; i++) {
                int iend = l - 1 + i;
                for (int j = 0; j <= m - l; j++) {
                    int jend = l - 1 + j;
                    dp[l][i][j] = false;
                    for (int k = i; k < iend; k++) {
                        int leftsize = k - i + 1;
                        int rightsize = l - leftsize;
                        bool c1, c2;
                        
                        c1 = dp[leftsize][i][j] && dp[rightsize][i+leftsize][j+leftsize];
                        c2 = dp[leftsize][i][j+rightsize] && dp[rightsize][i+leftsize][j];
                        
                        dp[l][i][j] = c1 || c2 || dp[l][i][j];
                        if (dp[l][i][j]) break;
                    }
                }
            }
        }
        
        return dp[m][0][0];
    }
};