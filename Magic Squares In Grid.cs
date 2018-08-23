public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        if (grid == null || grid.Length <= 2 || grid[0].Length <= 2) {
            return 0;
        }
        
        var count = 0;
        var m = grid.Length;
        var n = grid[0].Length;
        for (var i = 1; i < m - 1; i++) {
            for (var j = 1; j < n - 1; j++) {
                if (grid[i][j] == 5) {
                    count += IsMagicSquares(grid, i, j);
                }
            }
        }
        
        return count;
    }
    
    private static readonly int[,] dirs = new int[4,2] {{-1,-1}, {-1,0}, {-1,1}, {0,1}};
    
    private int IsMagicSquares(int[][] grid, int i, int j) {
        var set = new HashSet<int> {1,2,3,4,6,7,8,9};
        for (var k = 0; k < 4; k++) {
            if (set.Remove(grid[i-dirs[k,0]][j-dirs[k,1]])) {
                if (grid[i-dirs[k,0]][j-dirs[k,1]] + grid[i+dirs[k,0]][j+dirs[k,1]] == 10) {
                    set.Remove(grid[i+dirs[k,0]][j+dirs[k,1]]);
                } else {
                    return 0;
                }
            } else {
                return 0;
            }  
        }
        return 1;
    }
}
