class Solution {
public:
    string map[10] = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
    vector<string> letterCombinations(string digits) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<string> res;
        res.push_back("");
        if (digits.size() == 0) return res;
        string chs;
        
        for (int i = 0; i < digits.length(); i++) {
            vector<string> tmp;
            chs = map[digits[i] - '0'];
            while (!res.empty()) {
                string s = res.back();
                res.pop_back();
                for (int i = 0; i < chs.length(); i++) {
                    tmp.push_back(string(s+chs[i]));
                }       
            }
            res = tmp;
        }
        return res;
    }
};