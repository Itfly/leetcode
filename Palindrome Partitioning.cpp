class Solution {
    
public:

    vector<vector<string> > helper(string s, int start, vector<vector<bool> > &isPalindromic) {
        vector<vector<string> > ret;
        
        if (s.length() == 0) {
            return ret;
        } 
        
        if (start == s.length()) {
            vector<string> vec;
            ret.push_back(vec);
            return ret;
        }
        
        for (int i = start; i < s.length(); i++) {
            if (isPalindromic[start][i]) {
                vector<vector<string> > tmp = helper(s, i+1, isPalindromic);
                for (int j = 0; j < tmp.size(); j++) {
                    vector<string> vec = tmp[j];
                    vec.insert(vec.begin(), s.substr(start, i-start+1));
                    ret.push_back(vec);
                }
            }
        }
        return ret;
    }
    
    vector<vector<string> > partition(string s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<bool> > isPalindromic(s.length(), vector<bool>(s.length()));
        for (int i = 0; i < s.length(); i++) {
            isPalindromic[i][i] = true;
        }
        
        for (int k = 1; k < s.length(); k++) {
            for (int i = 0; i < s.length()-k; i++) {
                int j = i+k;
                isPalindromic[i][j] = (s[i] == s[j] && (j - i <= 2 || isPalindromic[i+1][j-1]));
            }
        }
        
        return helper(s, 0, isPalindromic);
        
    
    }
};