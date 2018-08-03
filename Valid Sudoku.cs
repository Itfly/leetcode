public class Solution {
    public bool IsValidSudoku(char[,] board) {
        if (board == null || board.Length != 81 || board.GetLength(0) != 9) {
            return false;
        }
        
        // check columns
        for (var i = 0; i < 9; i++) {
            var m = new bool[9];
            for (var j = 0; j < 9; j++) {
                var ch = board[i, j];
                if (ch != '.') {
                    if (m[ch - '1']) {
                        return false;
                    }
                    m[ch - '1'] = true;
                }
            }
        }
        
        // check rows
        for (var j = 0; j < 9; j++) {
            var m = new bool[9];
            for (var i = 0; i < 9; i++) {
                var ch = board[i, j];
                if (ch != '.') {
                    if (m[ch - '1']) {
                        return false;
                    }
                    m[ch - '1'] = true;
                }
            }
        }
        
        // check sub-matrixes
        for (var k = 0; k < 9; k++) {
            var m = new bool[9];
            for (var i = k / 3 * 3; i < k / 3 * 3 + 3; i++) {
                for (var j = k % 3 * 3; j < k % 3 * 3 + 3; j++) {
                    var ch = board[i, j];
                    if (ch != '.') {
                        if (m[ch - '1']) {
                            return false;
                        }
                        m[ch - '1'] = true;
                    }    
                }
            }
        }
        
        return true;
    }
}
