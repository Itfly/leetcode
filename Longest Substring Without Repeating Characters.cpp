class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int n = s.length();
        if (n <= 1) {
            return n;
        }
        int maxlen = 0, last_start = 0;
        char hash[26];
        memset(hash, -1, sizeof(hash));
        
        hash[s[0]-'a'] = 0;
        int curlen = 1;
        for (int i = 1; i < n; i++) {
            int index = s[i] - 'a';
            if (hash[index] == -1) {
                hash[index] = i;
                ++curlen;
            } else {
                if (last_start <= hash[index]) {
                    curlen = i - hash[index];
                    last_start = hash[index] + 1;
                } else {
                    ++curlen;
                }
                hash[index] = i;
            }
            if (curlen > maxlen) {
                maxlen = curlen;
            }
        }
        
        return maxlen;
    }
};


class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int n = s.length();
        if (n == 0) return 0;
        int longest = 1;
        //vector<int> dp(n);
        //dp[0] = 1;
        int last = 1;
        
        for (int i = 1; i < n; i++) {
            int j;
            for (j = 0; j < last; j++) {
                if (s[i-j-1] == s[i]) break;
            }
            if (j == last) {
                last = last + 1;
            } else {
                last = j + 1;
            }
            longest = max(longest, last);
        }
        return longest;
    }
};