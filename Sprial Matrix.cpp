class Solution {
public:
    void spiralOutCircle(vector<vector<int >> &rect, vector<int> &seq, int rStart, int cStart, int m, int n) {
        	if (m <= 0 || n <= 0) return;

			if (m == 1) {
    		    for (int i = 0; i < n; i++) {
        	        seq.push_back(rect[rStart][i+cStart]);   
    		    }   
                return;
			}
            
            if (n == 1) {
                for (int i = 0; i < m; i++) {
                    seq.push_back(rect[i+rStart][cStart]);
                }
                return;
            }
            
            for (int i = 0; i < n; i++) {
					seq.push_back(rect[rStart][i+cStart]);
			}
			
			for (int i = 1; i < m; i++) {
					seq.push_back(rect[i+rStart][cStart+n-1]);
			}
			
			for (int i = n-2; i >= 0; i--) {
					seq.push_back(rect[rStart+m-1][i+cStart]);
			}
			
			for (int i = m-2; i >0; i--) {
					seq.push_back(rect[i+rStart][cStart]);
			}
			
			spiralOutCircle(rect, seq, rStart+1, cStart+1, m-2, n-2);
    }   
    vector<int> spiralOrder(vector<vector<int> > &matrix) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<int> result;
        int m = matrix.size();
        if (m == 0) return result;
        int n = matrix[0].size();
        
        result.resize(m*n);
        result.clear();
        spiralOutCircle(matrix, result, 0, 0, m, n);
        
        return result;
    }
};


class Solution {
public:
    vector<int> spiralOrder(vector<vector<int> > &matrix) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<int> result;
        int m = matrix.size();
        if (m == 0) return result;
        int n = matrix[0].size();
        int count = m * n;
        int k = 0;
        while (count > 0) {
            for (int i = k; i < n - k; i++) {
                result.push_back(matrix[k][i]);
                --count;
            }
            if (count == 0) break;
            for (int i = k + 1; i < m - k; i++) {
                result.push_back(matrix[i][n-k-1]);
                --count;
            }
            if (count == 0) break;
            for (int i = n - k - 2; i >= k; i--) {
                result.push_back(matrix[m-k-1][i]);
                --count;
            }
            if (count == 0) break;
            for (int i = m - k - 2; i > k; i--) {
                result.push_back(matrix[i][k]);
                --count;
            }
            k++;
            
        }
        return result;
    }
};