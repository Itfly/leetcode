public class Solution {
    public int CountBattleships(char[,] board) {
        var count = 0;
        var m = board.GetLength(0);
        var n = board.GetLength(1);
        for (var i = 0; i < m; i++) {
            for (var j = 0; j < n; j++) {
                if (board[i, j] == '.' 
                    || (i != 0 && board[i - 1, j] == 'X')
                    || (j != 0 && board[i, j - 1] == 'X')) {
                    continue;
                }
                count++;
            }
        }
        
        return count;
    }
}