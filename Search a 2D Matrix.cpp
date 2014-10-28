class Solution {
public:
    bool searchMatrix(vector<vector<int> > &matrix, int target) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int m = matrix.size();
        if (m == 0) return false;
        int n = matrix[0].size();
        int low = 0, high = m*n - 1;
        while (low <= high) {
            int mid = low + (high - low) / 2;
            int cur = matrix[mid/n][mid%n];
            if (cur == target) {
                return true;
            } else if (cur > target) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        
        return false;
    }
};