public class Solution {
    public int MaximalSquare(char[,] matrix) {
        if (matrix == null || matrix.Length == 0) {
            return 0;
        }
        
        var dp = new int[matrix.GetLength(0), matrix.GetLength(1)];
        var max = 0;
        for (var i = 0; i < matrix.GetLength(0); i++) {
            dp[i, 0] = matrix[i, 0] - '0';
            max = Math.Max(dp[i, 0], max);
        }
        
        for (var i = 0; i < matrix.GetLength(1); i++) {
            dp[0, i] = matrix[0, i] - '0';
            max = Math.Max(dp[0, i], max);
        }
        
        for (var i = 1; i < matrix.GetLength(0); i++) {
            for (var j = 1; j < matrix.GetLength(1); j++) {
                if (matrix[i, j] == '1') {
                    dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                    max = Math.Max(dp[i, j], max);
                }
            }
        }
        
        return max * max;
    }
}
