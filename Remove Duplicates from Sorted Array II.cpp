class Solution {
public:
    int removeDuplicates(int A[], int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (n == 0) return 0;
        bool isTwice = false;
        int last = 1;
        for (int i = 1; i < n; i++) {
            if (A[i] == A[i-1] && !isTwice) {
                isTwice = true;
                A[last++] = A[i];
            } else if (A[i] != A[i-1]) {
                isTwice = false;
                A[last++] = A[i];
            }
        }
        
        return last;
    }
};
