class Solution {
public:
    
    void nextPermutation(vector<int> &num) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<int>::iterator i, j, k;
        i = num.end() - 2;
        j = k = num.end() - 1;
        while (i >= num.begin() && *i >= *j) {
            i--;
            j--;
        }
        
        if (i < num.begin()) {
            reverse(num.begin(), num.end());
            return;
        }
        
        while (*i >= *k) {
            k--;
        }
        
        swap(*i, *k);
        reverse(j, num.end());
    }
};