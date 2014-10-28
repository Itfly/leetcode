class Solution {
public:
    vector<int> grayCode(int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<int> res;
        if (n == 0) {
            res.push_back(0);
            return res;
        }
        n = 1 << n;
        for (int i = 0; i < n; i++) {
            res.push_back(i^(i>>1));
        }
        return res;
    }
};