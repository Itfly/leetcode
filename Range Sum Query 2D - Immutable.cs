public class NumMatrix {
    private int[,] sums;

    public NumMatrix(int[,] matrix) {
        if (matrix == null || matrix.Length == 0) {
            return;
        }
        
        var m = matrix.GetLength(0);
        var n = matrix.GetLength(1);
        sums = new int[m + 1, n + 1];
        
        for (var i = 0; i < m; i++) {
            var sum = 0;
            for (var j = 0; j < n; j++) {
                sum += matrix[i, j];
                sums[i + 1, j + 1] += sums[i, j + 1] + sum;
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        if (sums == null) {
            return 0;
        }
        
        return sums[row2 + 1, col2 + 1] + sums[row1, col1] - sums[row2 + 1, col1] - sums[row1, col2 + 1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */
