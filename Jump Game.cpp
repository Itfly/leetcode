class Solution {
public:
    bool canJump(int A[], int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int last = 0;
        for (int i = 0; i < n; i++) {
            if (i > last) return false;
            last = max(last, i + A[i]);
        }
        return true;
    }
};