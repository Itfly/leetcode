class Solution {
public:
    int firstMissingPositive(int A[], int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int i = 0;
        while(i < n) {
            if (A[i] > 0 && A[i] <= n) {
                if (A[i] != i+1 && A[A[i]-1] != A[i]) {
                    int tmp = A[A[i]-1];
                    A[A[i]-1] = A[i];
                    A[i] = tmp;
                } else {
                    i++;
                }
            } else {
                i++;
            }
        }
        
        for (int i = 0; i < n; i++) {
            if (A[i] != i+1) return i+1;
        }
        
        return n+1;
    }
};