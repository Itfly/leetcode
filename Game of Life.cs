public class Solution {
    private static readonly int[,] dirs = new int[8, 2] {{-1, 0}, {-1, 1}, {-1, -1}, {0, 1}, {0, -1}, {1, 0}, {1, -1}, {1, 1}};
    
    private int CountLiveNeighbors(int[][] board, int i, int j) {
        var count = 0;
        for (var k = 0; k < 8; k++) {
            var ii = i + dirs[k, 0];
            var jj = j + dirs[k, 1];
            if (ii >= 0 && ii < board.Length && jj >= 0 && jj < board[0].Length && (board[ii][jj] & 1) == 1) {
                count++;
            }
        }
        
        return count;
    } 
    
    public void GameOfLife(int[][] board) {
        for (var i = 0; i < board.Length; i++) {
            for (var j = 0; j < board[0].Length; j++) {
                var count = CountLiveNeighbors(board, i, j);
                if ((board[i][j] & 1) == 1) {
                    if (count == 2 || count == 3) {
                        board[i][j] = 3;
                    } else {
                        board[i][j] = 1;
                    }
                } else {
                    if (count == 3) {
                        board[i][j] = 2;
                    }
                }
            }
        }
        
        for (var i = 0; i < board.Length; i++) {
            for (var j = 0; j < board[0].Length; j++) {
                board[i][j] = board[i][j]>>1;

            }
        }
    }
}
