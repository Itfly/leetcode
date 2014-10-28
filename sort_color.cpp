class Solution {
public:
    void swap(int &x, int &y) {
        int t = x;
        x = y;
        y = t;
    }
    void sortColors(int A[], int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int i, j, k;
        i = j = 0;
        k = n-1;
        
        while (j <= k) {
            if (A[j] == 0) {
                swap(A[i++], A[j++]);       
            } else if (A[j] == 1) {
                j++;
            } else {
                swap(A[j], A[k--]);
            }
        }
    }
};