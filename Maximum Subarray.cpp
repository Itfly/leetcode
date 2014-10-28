class Solution {
public:
    int maxSubArray(int A[], int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int result = INT_MIN, last = -1;
        for (int i = 0; i < n; i++) {
            if (last <= 0) {
                last = A[i];
            } else {
                last += A[i];
            }
            result = max(result, last);
        }
        return result;
    }
};