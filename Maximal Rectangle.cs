public class Solution {
    public int MaximalRectangle(char[,] matrix) {
        if (matrix == null || matrix.Length == 0) {
            return 0;
        }
        
        var result = 0;
        var m = matrix.GetLength(0);
        var n = matrix.GetLength(1);
        var lefts = new int[n]; // the left outmost location of same height '1' lines.
        var rights = Enumerable.Repeat(n, n).ToArray(); // the right outmost location of same height '1' lines.
        var highes = new int[n];
        for (var i = 0; i < m; i++) {
            var left = 0;
            for (var j = 0; j < n; j++) {
                if (matrix[i, j] == '1') {
                    highes[j]++;
                    lefts[j] = Math.Max(lefts[j], left);
                } else {
                    left = j + 1;
                    highes[j] = 0;
                    lefts[j] = 0;
                }
            }
            
            var right = n;
            for (var j = n - 1; j>= 0; j--) {
                if (matrix[i, j] == '1') {
                    rights[j] = Math.Min(rights[j], right);
                    result = Math.Max(result, highes[j] * (rights[j] - lefts[j]));
                } else {
                    right = j;
                    rights[j] = n;
                }
            }
        }
        
        return result;
    }
}
