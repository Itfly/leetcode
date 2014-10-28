class Solution {
public:
    int maximalRectangle(vector<vector<char> > &matrix) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (matrix.size() == 0) return 0;
        
        int n = matrix[0].size();
        vector<int> h(n);
        vector<int> l(n);
        vector<int> r(n, n);
        
        int ret = 0;
        for (int i = 0; i < matrix.size(); i++) {
            int left = 0, right = n;
            for (int j = 0; j < n; j++) {
                if (matrix[i][j] == '1') {
                    h[j]++;
                    l[j] = max(l[j], left);
                } else {
                    left = j + 1;
                    h[j] = 0;
                    l[j] = 0;
                    r[j] = n;
                }
            }
            
            for (int j = n - 1; j >= 0; j--) {
                if (matrix[i][j] == '1') {
                    r[j] = min(r[j], right);
                    ret = max(ret, h[j] * (r[j] - l[j]));
                } else {
                    right = j;
                }
            }
        }
        
        return ret;
    }
};