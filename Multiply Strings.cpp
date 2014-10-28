class Solution {
public:

    string multiply(string num1, string num2) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (num1[0] == '0' || num2[0] == '0') return "0";
        int n1 = num1.length();
        int n2 = num2.length();
        int n = n1 + n2;
        vector<int> r(n,0);
        string res(n, '0');
        
        for (int i = 0; i < n1; i++) {
            for (int j = 0; j < n2; j++) {
                r[i+j+1] += (num1[i] - '0') * (num2[j] - '0');
            }
        }
        
        for (int i = n-1; i > 0; i--) {
            if (r[i] > 9) {
                r[i-1] += r[i] / 10;
            }
            res[i] += r[i] % 10;
        }
        res[0] += r[0];
        
        return res[0] == '0' ? res.substr(1) : res;
    }
};


