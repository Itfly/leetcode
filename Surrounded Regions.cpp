class Solution {
		int row, col;
public:
		void bsf(int i, int j, vector<vector<char>> &board) {
				if (board[i][j] != 'O') return;
				board[i][j] == 'M';
				if (i+1 < row) {
						board(i+1, j, board);
				}
				if (i-1 >= 0) {
						board(i-1, j, board);
				}
				if (j+1 < col) {
						board(i, j+1, board);
				}
				if (j-1 >= 0) {
						board(i, j-1, board);
				}
		}
		
    void solve(vector<vector<char>> &board) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int m = board.size();
        if (m == 0) return;
        int n = board[0].size();
        if (n == 0) return;
        row = m;
        col = n;
        for (int i = 0; i < m) {
    				bsf(i, 0, board);
    				bsf(i, n-1, board);
    		}
    		for (int i = 0; i < n) {
    				bsf(0, i, board);
    				bsf(m-1,i, board);
    		}
    
		    for (int i = 0; i < m) {
		    		for (int j = 0; j < n) {
		    				if (board[i][j] == 'M') {
		    						board[i][j] = 'O';
		    				} else if (board[i][j] == 'O') {
		    						board[i][j] = 'X';
		    				}
		    		}
		   	}
    }
};