class Solution {
public:
    
    int totalNQueens(vector<int> &x, int t, int n) {
        if (t > n) {
            return 1;
        }
        
        int sum = 0;
        for (int i = 1; i <= n; i++) {  
            int j;
            for (j = 1; j < t; j++) {
                if (abs(i - x[j]) == (t - j) || i == x[j]) break;
            }
            
            if (j == t) {
                x[t] = i;
                sum += totalNQueens(x, t+1, n);
            }
        }
        return sum;
    }
    int totalNQueens(int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<int> x(n+1);
        return totalNQueens(x, 1, n);
    }
};



class Solution {
public:
    int count;
    int mask;
    void dfs(int col, int diag1, int diag2) {
        if (col == mask) {
            count++;
        }
        
        int cur = (~(col | diag1 | diag2)) & mask;
        while (cur) {
            int lowbit = cur & (-cur);
            dfs(col | lowbit, (diag1 | lowbit) >> 1, ((diag2 | lowbit) << 1) & mask);
            cur -= lowbit;
        }
    }
    int totalNQueens(int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        mask = (1 << n) - 1;
        count = 0;
        dfs(0, 0, 0);
        return count;
    }
};
