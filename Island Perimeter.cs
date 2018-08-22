public class Solution {
    public int IslandPerimeter(int[,] grid) {
        var islands = 0;
        var neighbours = 0;
        
        for (var i = 0; i < grid.GetLength(0); i++) {
            for (var j = 0; j < grid.GetLength(1); j++) {
                if (grid[i, j] == 0) {
                    continue;
                }
                
                islands++;
                if (i < grid.GetLength(0) - 1 && grid[i + 1, j] == 1) {
                    neighbours++;
                }
                if (j < grid.GetLength(1) - 1 && grid[i, j + 1] == 1) {
                    neighbours++;
                }
            }
        }
        
        return 4 * islands - 2 * neighbours;
    }
}
