class Solution {
public:
    int searchInsert(int A[], int n, int target) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int low = 0, high = n - 1, mid;
        while (low <= high) {
            mid = low + (high - low) / 2;
            if (A[mid] == target) return mid;
            if (A[mid] < target) {
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }
        
        return A[mid] < target ? mid + 1 : mid;
    }
};