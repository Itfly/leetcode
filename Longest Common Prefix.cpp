class Solution {
public:
    string CommonPrefix(string s1, string s2) {
        string s = "";
        int i = 0; 
        int n = min(s1.length(), s2.length());
        while (s1[i] == s2[i]) {
            s += s1[i++];
        }
        return s;
    }
    string longestCommonPrefix(vector<string> &strs) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (strs.empty()) return "";
        
        int pos = strs[0].length();
        for (int i = 1; i < strs.size(); i++) {
            for (int j = 0; j < pos; j++) {
                if (strs[i][j] != strs[0][j]) {
                    pos = j;
                    break;
                }
            }
            
         //   if (prefix == "") break;
        }
        return strs[0].substr(0, pos);
    }
};