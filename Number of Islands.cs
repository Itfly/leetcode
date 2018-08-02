public class Solution {
    public int NumIslands(char[,] grid) {
        if (grid == null || grid.Length == 0) {
            return 0;
        }
        
        var m = grid.GetLength(0);
        var n = grid.GetLength(1);
        var cnt = 0;
        for (var i = 0; i < m; i++) {
            for (var j = 0; j < n; j++) {
                if (grid[i, j] == '0') {
                    continue;
                }
                
                ++cnt;
                bfs(grid, i, j, m, n);
            }
        }
        
        return cnt;
    }
    
    private void dfs(char[,] grid, int i, int j, int m, int n) {
        if (i < 0 || i >= m || j < 0 || j >= n) {
            return;
        }
        
        if (grid[i, j] == '1') {
            grid[i, j] = '0';
            dfs(grid, i - 1, j, m, n);
            dfs(grid, i + 1, j, m, n);
            dfs(grid, i, j - 1, m, n);
            dfs(grid, i, j + 1, m, n);
        }
    }
    
    private static int[,] dir = new int[4,2] { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };
    
    private void bfs(char[,] grid, int i, int j, int m, int n) {
        if (i < 0 || i >= m || j < 0 || j >= n) {
            return;
        }
        
        var queue = new Queue<int>();
        queue.Enqueue(i * n + j);
        grid[i, j] = '0';
        while (queue.Count > 0) {
            var loc = queue.Dequeue();
            i = loc / n;
            j = loc % n;
            
            for (var k = 0; k < 4; k++) {
                var ii = i + dir[k, 0];
                var jj = j + dir[k, 1];
                if (ii >= 0 && ii < m && jj >= 0 && jj < n && grid[ii, jj] == '1') {
                    queue.Enqueue(ii * n + jj);
                    grid[ii, jj] = '0';
                }
            }
        }
    }
}
