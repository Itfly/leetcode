class Solution {
public:
    int minimumTotal(vector<vector<int> > &triangle) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int m = triangle.size();
        vector<int> sum(triangle[m-1]);
        for (int i = m - 2; i >= 0; --i) {
            for (int j = 0; j <= i; j++) {
                sum[j] = min(sum[j], sum[j+1]) + triangle[i][j];
            }
        }
        return sum[0];
    }
    
};