class Solution {
public:

    vector<vector<int> > generateMatrix(int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> > matrix(n, vector<int>(n));
        int cnt = 1, num = n*n;
        int first = 0, last = n;
        while (cnt <= num) {
            for (int i = first; i < last; i++) {
                matrix[first][i] = cnt++;
            }
            
            for (int i = first + 1; i < last; i++) {
                matrix[i][last-1] = cnt++;
            }
            
            for (int i = last - 2; i >= first; i--) {
                matrix[last-1][i] = cnt++;
            }
            
            for (int i = last - 2; i > first; i--) {
                matrix[i][first] = cnt++;
            }
            first++;
            last--;
        }
        
        return matrix;
    }
};


class Solution {
public:
    void generateMatrix(vector<vector<int> > & matrix, int k, int len, int startnum) {
        if (len <= 0) return;
        for (int i = 0; i < len; i++) {
            matrix[k][k+i] = startnum++;
        }
        for (int i = 1; i < len; i++) {
            matrix[k+i][k+len-1] = startnum++;
        }
        for (int i = len-2; i >= 0; i--) {
            matrix[k+len-1][k+i] = startnum++;
        }
        for (int i = len-2; i > 0; i--) {
            matrix[k+i][k] = startnum++;
        }
        generateMatrix(matrix, k+1, len-2, startnum);
    }
    vector<vector<int> > generateMatrix(int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> > ret(n, vector<int>(n));
        generateMatrix(ret, 0, n, 1);
        return ret;
    }
};