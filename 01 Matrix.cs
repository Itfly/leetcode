public class Solution {
    private static int[,] dirs = new int[4, 2] {{-1, 0}, {1, 0}, {0, 1}, {0, -1}};

    public int[,] UpdateMatrix(int[,] matrix) {
        if (matrix == null || matrix.Length == 0) {
            return matrix;
        }
        
        var m = matrix.GetLength(0);
        var n = matrix.GetLength(1);
        var queue = new Queue<int>();
        
        for (var i = 0; i < m; i++) {
            for (var j = 0; j < n; j++) {
                if (matrix[i, j] == 0) {
                    queue.Enqueue(i * n + j);
                } else {
                    matrix[i, j] = int.MaxValue;
                }
            }
        }
        
        while (queue.Count > 0) {
            var cur = queue.Dequeue();
            var i = cur / n;
            var j = cur % n;
            for (var k = 0; k < 4; k++) {
                var ii = i + dirs[k, 0];
                var jj = j + dirs[k, 1];
                if (ii >= 0 && ii < m && jj >= 0 && jj < n && matrix[ii, jj] > matrix[i, j]) {
                    matrix[ii, jj] = matrix[i, j] + 1;
                    queue.Enqueue(ii * n + jj);
                }
            }
        }
        
        return matrix;
    }
}
