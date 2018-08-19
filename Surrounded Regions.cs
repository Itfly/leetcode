public class Solution {
    public void Solve(char[,] board) {
        if (board == null || board.Length == 0) {
            return;
        }
        
        var m = board.GetLength(0);
        var n = board.GetLength(1);
        
        for (var i = 0; i < n; i++) {
            BFS(board, 0, i);
            BFS(board, m - 1, i);
        }
        for (var i = 0; i < m; i++) {
            BFS(board, i, 0);
            BFS(board, i, n - 1);
        }
        
        for (var i = 0; i < m; i++) {
            for (var j = 0; j < n; j++) {
                if (board[i, j] == 'O') {
                    board[i, j] = 'X';
                } else if (board[i, j] == '#') {
                    board[i, j] = 'O';
                }
            }
        }
    }
    
    private void BFS(char[,] board, int i, int j) {
        if (board[i, j] == 'X') {
            return;
        }
        
        var m = board.GetLength(0);
        var n = board.GetLength(1);
        var queue = new Queue<int>();
        queue.Enqueue(i * n + j);
        board[i, j] = '#';
        while (queue.Count > 0) {
            var cur = queue.Dequeue();
            i = cur / n;
            j = cur % n;
            
            
            if (i >= 1 && board[i - 1, j] == 'O') {
                board[i - 1, j] = '#';
                queue.Enqueue((i - 1) * n + j);
            }
            if (i + 1 < m && board[i + 1, j] == 'O') {
                board[i + 1, j] = '#';
                queue.Enqueue((i + 1) * n + j);
            }
            if (j >= 1 && board[i, j - 1] == 'O') {
                board[i, j - 1] = '#';
                queue.Enqueue(i * n + j - 1);
            }
            if (j + 1 < n && board[i, j + 1] == 'O') {
                board[i, j + 1] = '#';
                queue.Enqueue(i * n + j + 1);
            }
        }
    }
}
