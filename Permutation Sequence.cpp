class Solution {
public:
    string getPermutation(int n, int k) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<int> fact(n);
        vector<int> index(n);
        fact[1] = 1;
        for (int i = 2; i < n; i++) {
            fact[i] = i * fact[i-1];
        }
        
        k--;
        for (int i = n - 1; i > 0 ; i--) {
            index[i] = k / fact[i];
            k = k % fact[i];
        }
        index[0] = 0;
        
        vector<int> num(n);
        for (int i = 0; i < n; i++) {
            num[i] = i + 1;
        }
        
        string ret = "";
        for (int i = n - 1; i >= 0; i--) {
            ret += to_string(num[index[i]]);
            num.erase(num.begin() + index[i]);
        }
        
        return ret;
    }
};