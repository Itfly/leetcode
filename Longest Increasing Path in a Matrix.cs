public class Solution {
    private static readonly int[,] dirs = new int[4, 2] {{-1, 0}, {1, 0}, {0, -1}, {0, 1}};
    
    public int LongestIncreasingPath(int[,] matrix) {
        if (matrix == null || matrix.Length == 0) {
            return 0;
        }
        
        var pathes = new int[matrix.GetLength(0), matrix.GetLength(1)];
        var longest = 0;
        
        for (var i = 0; i < matrix.GetLength(0); i++) {
            for (var j = 0; j < matrix.GetLength(1); j++) {
                longest = Math.Max(longest, DFS(matrix, i, j, pathes));
            }
        }
        
        return longest;
    }
    
    private int DFS(int[,] matrix, int i, int j, int[,] pathes) {
        if (pathes[i, j] != 0) {
            return pathes[i, j];
        }
        
        var longest = 0;
        for (var k = 0; k < 4; k++) {
            var ii = i + dirs[k, 0];
            var jj = j + dirs[k, 1];
            if (ii >= 0 && ii < matrix.GetLength(0) 
                && jj >= 0 && jj < matrix.GetLength(1) 
                && matrix[ii, jj] > matrix[i, j]) {
                longest = Math.Max(longest, DFS(matrix, ii, jj, pathes));
            }
        }
        pathes[i, j] = longest + 1;
        
        return pathes[i, j];
    }
}
