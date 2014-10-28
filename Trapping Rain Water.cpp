class Solution {
public:
    int trap(int A[], int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (n == 0) return 0;
        
        int wall = 0, water = 0, cur = 0;
        
        for (int i = 0; i < n; i++) {
            if (A[i] > A[wall]) {
                wall = i;
            }
        }
        
        for (int i = 0; i < wall; i++) {
            if (cur > A[i]) {
                water += cur - A[i];
            } else {
                cur = A[i];
            }
        }
        
        cur = 0;
        for (int i = n-1; i > wall; i--) {
            if (cur > A[i]) {
                water += cur - A[i];
            } else {
                cur = A[i];
            }
        }
        
        return water;
        
    }
};