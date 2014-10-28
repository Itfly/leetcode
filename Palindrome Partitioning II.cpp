class Solution {
public:
    
    int minCut(string s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int n = s.length();
        if (n <= 1) return 0;
        
        vector<int> dp(n, 0);
        vector<vector<bool> > isPalindrome(n, vector<bool>(n, false));
        
        dp[0] = 0;
        
        for (int i = 1; i < n; i++) {
            dp[i] = i;
            if (s[0] == s[i] && (i <= 2 || isPalindrome[1][i-1])) {
                dp[i] = 0;
                isPalindrome[0][i] = true;
            }
            for(int k = 1; k <= i; k++) {
                if (s[k] == s[i] &&(i - k <=2 || isPalindrome[k+1][i-1])) {
                    isPalindrome[k][i] = true;
                    dp[i] = min(dp[i], dp[k-1]+1);
                }
            }
        }
        return dp[n-1];
    }
};