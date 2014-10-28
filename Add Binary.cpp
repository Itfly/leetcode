class Solution {
public:
    string addBinary(string a, string b) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int m = a.length();
        int n = b.length();
        int carry = 0;
        int i, j;
        string res;
                
        for (i = m - 1, j = n - 1; i >= 0 && j >= 0; i--, j--) {
            int sum = (a[i] - '0') + (b[j] - '0') + carry;
            res.append(1, (sum%2 + '0'));
            carry = sum / 2;
        }
        
        while (i >= 0) {
            int sum = a[i] - '0' + carry;
            res.append(1, (sum%2 + '0'));
            carry = sum / 2;
            i--;
        }
        while (j >= 0) {
            int sum = b[j] - '0' + carry;
            res.append(1, (sum%2 + '0'));
            carry = sum / 2;
            j--;
        }
        if (carry == 1) res.append(1, '1');
        
        reverse(res.begin(), res.end());
        
        return res;
    }
};