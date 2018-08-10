public class Solution {
    public void SetZeroes(int[,] matrix) {
        if (matrix == null || matrix.Length == 0) {
            return;   
        }
        
        var m = matrix.GetLength(0);
        var n = matrix.GetLength(1);
        bool frz = false;
        bool fcz = false;
        
        if (matrix[0, 0] == 0) {
            frz = true;
            fcz = true;
        } else {
            for (var i = 0; i < n; i++) {
                if (matrix[0, i] == 0) {
                    frz = true;
                    break;
                }
            }
            for (var i = 0; i < m; i++) {
                if (matrix[i, 0] == 0) {
                    fcz = true;
                    break;
                }
            }
        }
        
        for (var i = 0; i < m; i++) {
            for (var j = 0; j < n; j++) {
                if (matrix[i, j] == 0) {
                    matrix[i, 0] = 0;
                    matrix[0, j] = 0;
                }
            }
        }
        
        for (var i = 1; i < m; i++) {
            for (var j = 1; j < n; j++) {
                if (matrix[i, 0] == 0 || matrix[0, j] == 0) {
                    matrix[i, j] = 0;
                }
            }
        }
        
        if (frz) {
            for (var i = 0; i < n; i++) {
                matrix[0, i] = 0;
            }
        }
        if (fcz) {
            for (var i = 0; i < m; i++) {
                matrix[i, 0] = 0;
            }
        }
    }
}
