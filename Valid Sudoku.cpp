class Solution {
public:
    bool isValidRow(vector<vector<char> > &board) {
        short num[10];
        for (int i = 0; i < 9; i++) {
            memset(num, 0, sizeof(short)*10);
            int j;
            for (j = 0; j < 9; j++) {
                if (isdigit(board[i][j])) {
                    num[board[i][j] - '0']++;
                    if (num[board[i][j] - '0'] > 1) break;
                }
            }
            if (j < 9) return false;
        }
        return true;
    }
    
    bool isValidCol(vector<vector<char> > &board) {
        short num[10];
        for (int j = 0; j < 9; j++) {
            memset(num, 0, sizeof(short)*10);
            int i;
            for (i = 0; i < 9; i++) {
                if (isdigit(board[i][j])) {
                    num[board[i][j] - '0']++;
                    if (num[board[i][j] - '0'] > 1) break;
                }
            }
            if (i < 9) return false;
        }
        return true;
    }
    
    bool isValidSubbox(vector<vector<char> > &board) {
        short num[10];
        for (int k = 0; k < 9; k++) {
            memset(num, 0, sizeof(short)*10);
            for (int i = 0; i < 3; i++) {
                int j;
                for (j = 0; j < 3; j++) {
                    char ch = board[(k/3)*3+i][(k%3)*3+j];
                    if (isdigit(ch)) {
                        num[ch - '0']++;
                        if (num[ch - '0'] > 1) break;
                    }
                }
                if (j < 3) return false;
            }
        }
        return true;
    }
    
    bool isValidSudoku(vector<vector<char> > &board) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (!isValidRow(board)) {
            return false;
        }
        if (!isValidCol(board)) {
            return false;
        }
        if (!isValidSubbox(board)) {
            return false;
        }
        
        return true;
        
    }
};