class Solution {
public:
    bool isInterleave(string s1, string s2, string s3) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function    
        int m = s1.length();
        int n = s2.length();
        if (m + n != s3.length()) return false;
        
        vector<bool> dp(n+1);
        dp[n] = true;
        for (int i = n - 1; i >= 0; i--) {
            if (!(dp[i] = s2[i] == s3[m+i] && dp[i+1])) {
                break;
            }
        }
        
        for (int i = m - 1; i >=0; i--) {
            dp[n] = s1[i] == s3[i+n] && dp[n];
            for (int j = n - 1; j >= 0; j--) {
                if (s1[i] == s3[i+j] && dp[j]) {
                    dp[j] = true;
                } else if (s2[j] == s3[i+j] && dp[j+1]) {
                    dp[j] = true;
                } else {
                    dp[j] = false;
                }
            }
        }
        
        return dp[0];
    }
};


class Solution {
public:
    bool isInterleave(string s1, string s2, string s3) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function   
        int n1, n2, n3;        
        n1 = s1.length();
        n2 = s2.length();
        n3 = s3.length();
       
        if (n1 + n2 != n3) return false;
        if (n1 == 0) return !s2.compare(s3);
        if (n2 == 0) return !s1.compare(s3);
        
        bool **dp = new bool*[n1+1];
        for(int i = 0;i < n1+1; i++){
            dp[i] = new bool[n2+1];
        }
        
        for (int i = 0; i < n1+1; i++) {
            dp[i][n2] = !s1.substr(i).compare(s3.substr(n2+i));
        }
        for (int i = 0; i < n2+1; i++) {
            dp[n1][i] = !s2.substr(i).compare(s3.substr(n1+i));
        }        
        //dp[n1-1][n2] = (s1[n1-1] == s3[n3-1]);
        //dp[n1][n2-1] = (s2[n2-1] == s3[n3-1]);
        
        for (int i = n1-1; i >= 0; i--)
    		for (int j = n2-1; j >= 0; j--) {
            bool temp1, temp2;
            temp1 = (s1[i] == s3[i+j] && dp[i+1][j]);
            temp2 = (s2[j] == s3[i+j] && dp[i][j+1]);
            dp[i][j] = (temp1 || temp2);
        }
        
        return dp[0][0];
    }
};