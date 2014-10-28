class Solution {
public:
    void helper(string s, int start, int step, string ip, vector<string> &res) {
        if (s.length() - start > (4 - step) * 3) return;
        if (s.length() - start < 4 - step) return;
        
        if (s.length() == start && step == 4) {
            ip.resize(ip.size() - 1);
            res.push_back(ip);
            return;
        }
        
        int num = 0;
        for (int i = start; i < start + 3; i++) {
            num = num * 10 + s[i] - '0';
            if (num < 256) {
                ip += s[i];
                helper(s, i+1, step+1, ip +'.', res);
            }
            if (num == 0) break;
        }
    }
    vector<string> restoreIpAddresses(string s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<string> res;
        string ip = "";
        helper(s, 0, 0, ip, res);
        return res;
    }
};