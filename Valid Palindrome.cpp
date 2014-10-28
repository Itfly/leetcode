class Solution {
public:
    bool isPalindrome(string s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (s.length() == 0) return true;
        int i = 0, j = s.length() - 1;
        
        while (i < j) {
            if (!isalnum(s[i])) {
                i++;
            } else if (!isalnum(s[j])) {
                j--;
            } else {
                if (s[i] == s[j] || abs(s[i] - s[j]) == 32) {
                    i++;
                    j--;
                } else {
                    return false;
                }
            }
        }
        
        return true;
    }
};



class Solution {
public:
    bool isPalindrome(string s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int n = s.length();
        if (n <= 1) return true;
        
        int i = 0, j = n - 1;
        while (i < j) {
            while (i < n && !isalnum(s[i])) {
                i++;
            }
            if (i >= j) break;
            while (j > 0 && !isalnum(s[j])) {
                j--;
            }
            if (j <= i) break;
            if (s[i] == s[j] || abs(s[i] - s[j]) == 32) {
                i++;
                j--;
            } else {
                return false;
            }
        }
        return true;
    }
};