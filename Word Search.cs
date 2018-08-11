public class Solution {    
    public bool Exist(char[,] board, string word) {
        if (board == null || board.Length == 0) {
            return false;
        }
        
        for (var i = 0; i < board.GetLength(0); i++) {
            for (var j = 0; j < board.GetLength(1); j++) {
                if (DFS(board, i, j, word, 0)) {
                    return true;
                }
            }
        }
        
        return false;
    }
    
    private bool DFS(char[,] board, int i, int j, string word, int start) {
        if (board[i, j] != word[start]) {
            return false;
        }
        
        if (start == word.Length - 1) {
            return true;
        }
        
        var ch = board[i, j];
        board[i, j] = '*';
        var existed = false;
        
        if (i > 0) {
            existed = DFS(board, i - 1, j, word, start + 1);
        }
        if (!existed && i < board.GetLength(0) - 1) {
            existed = DFS(board, i + 1, j, word, start + 1);
        }
        if (!existed && j > 0) {
            existed = DFS(board, i, j - 1, word, start + 1);
        }
        if (!existed && j < board.GetLength(1) - 1) {
            existed = DFS(board, i, j + 1, word, start + 1);
        }
        
        board[i, j] = ch;
        return existed;
    }
}
