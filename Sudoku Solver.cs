public class Solution {
    public void SolveSudoku(char[,] board) {
        DFS(board, 0, 0);
    }
    
    private bool DFS(char[,] board, int i, int j) {
        if (i == 9) {
            return true;
        }
        
        if (j >= 9) {
            return DFS(board, i + 1, 0);
        }
        
        if (board[i, j] == '.') {
            for (var k = 1; k <= 9; k++) {
                board[i, j] = (char) (k + '0');
                if (IsValid(board, i, j)) {
                    if (DFS(board, i, j + 1)) {
                        return true;
                    }
                }
                
            }
            board[i, j] = '.';
        } else {
            return DFS(board, i, j + 1);
        }
        
        return false;
    }
    
    private bool IsValid(char[,] board, int i, int j) {
        for (var row = 0; row < 9; row++) {
            if (row != i && board[i, j] == board[row, j]) {
                return false;
            }
        }
        
        for (var col = 0; col < 9; col++) {
            if (col != j && board[i, j] == board[i, col]) {
                return false;
            }
        }
        
        for (var row = i / 3 * 3; row < i / 3 * 3 + 3; row++) {
            for (var col = j / 3 * 3; col < j / 3 * 3 + 3; col++) {
                if ((row != i || col != j) && board[i, j] == board[row, col]) {
                    return false;
                }
            }
        }
        
        return true;
    }
}

// TODO: refactor the cpp code
