public class Solution {
    private static int[,] dir = new int[4,2] { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };
    
    public int MaxAreaOfIsland(int[,] grid) {
        var max = 0;
        for (var i = 0; i < grid.GetLength(0); i++) {
            for (var j = 0; j < grid.GetLength(1); j++) {
                if (grid[i, j] == 1) {
                    max = Math.Max(max, AreaOfIsland(grid, i, j));
                }
            }
        }
        
        return max;
    }
    
    private int AreaOfIsland(int[,] grid, int i, int j) {
        if (i >= 0 && i < grid.GetLength(0) && j >= 0 && j < grid.GetLength(1) && grid[i, j] == 1) {
            grid[i, j] = 0;
            var sum = 1;
            for (var k = 0; k < 4; k++) {
                sum += AreaOfIsland(grid, i + dir[k, 0], j + dir[k, 1]);
            }
            
            return sum;
        }
        
        return 0;
    }
}
