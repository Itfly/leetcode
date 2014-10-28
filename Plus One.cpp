class Solution {
public:
    vector<int> plusOne(vector<int> &digits) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int carry = 0;
        int n = digits.size();
        vector<int> result(n);
        int i;
        digits[n-1]++;
        for (i = n-1; i >= 0; i--) {
            int tmp = digits[i] + carry;
            if (tmp == 10) {
                result[i] = 0;
                carry = 1;
            } else {
                result[i] = tmp;
                break;
            }
        }
        
        if (i < 0) result.insert(result.begin(), 1);
        else {
            i--;
            while (i >= 0) {
                result[i] = digits[i];
                i--;
            }    
        }
         
        return result;
        
    }
};


class Solution {
public:
    vector<int> plusOne(vector<int> &digits) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int n = digits.size(), i = n -1;
        //vector<int> result(n);
        digits[n-1]++;
        while (i > 0 && digits[i] >= 10) {
            digits[i] = 0;
            digits[--i]++;
        }
        if (digits[0] == 10) {
            digits[0] = 0;
            digits.insert(digits.begin(), 1);
        } 
        return digits;
    }
};