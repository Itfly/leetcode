class Solution {
public:
    void totalNQueens(vector<vector<string> > &result, vector<int> &x, int t, int n) {
        if (t > n) {
            vector<string> ans(n);
            for (int i = 0; i < n; i++) {
                string row(n, '.');
                row[x[i+1]-1] = 'Q';
                ans[i] = row;
            }
            result.push_back(ans);
            return;
        }
        
        for (int i = 1; i <= n; i++) {  
            int j;
            for (j = 1; j < t; j++) {
                if (abs(i - x[j]) == (t - j) || i == x[j]) break;
            }
            
            if (j == t) {
                x[t] = i;
                totalNQueens(result, x, t+1, n);
            }
        }
    }
    vector<vector<string> > solveNQueens(int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<string> > result;
        if (n == 0) return result;
        vector<int> x(n+1);
        totalNQueens(result, x, 1, n);
        
        return result;
    }
};



class Solution {
    int mask;
    //string s;
    int n;
public:
    inline int getpos(int x) {
        int count = 0;
        while (x > 1) {
            x >>= 1;
            count++;
        }
        return count;
    }
    void dfs(int col, int diag1, int diag2, vector<vector<string> > &result, vector<int> &path) {
        if (col == mask) {
            int n = path.size();
            vector<string> ans;
            for (int i = 0; i < n; i++) {
                string s(n, '.');
                s[n - 1 - getpos(path[i])] = 'Q';
                ans.push_back(s);
            }
            result.push_back(ans);
            return;
        }
        
        int cur = (~(col | diag1 | diag2)) & mask;
        while (cur) {
            int lowbit = cur & (-cur);
            path.push_back(lowbit);
            dfs(col | lowbit, (diag1 | lowbit) >> 1, ((diag2 | lowbit) << 1) & mask, result, path); 
            path.pop_back();
            cur -= lowbit;
        }
    }
    vector<vector<string> > solveNQueens(int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        mask = (1 << n) - 1;
        //s = string(n, '.');
        this->n = n;
        vector<vector<string> > result;
        vector<int> path;
        dfs(0, 0, 0, result, path);
        return result;
    }
};