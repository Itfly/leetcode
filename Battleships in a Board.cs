public class Solution {
    public int CountBattleships(char[,] board) {
        var count = 0;
        var m = board.GetLength(0);
        var n = board.GetLength(1);
        for (var i = 0; i < m; i++) {
            var j = 0;
            while (j < n) {
                if (board[i, j] == '.' || (i != 0 && board[i - 1, j] == 'X')) {
                    j++;
                    continue;
                }
                
                count++;
                if (i != m - 1 && board[i + 1, j] == 'X') {
                    j++;
                } else {
                    while (j < n && board[i, j] == 'X') {
                        j++;
                    }
                }
            }
        }
        
        return count;
    }
}
