public class Solution {
    public void Rotate(int[,] matrix) {
        var n = matrix.GetLength(0);
        for (var i = 0; i < n / 2; i++) {
            for (var j = i ; j < n - i - 1; j++) {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[n-1-j, i];
                matrix[n-1-j, i] = matrix[n-1-i, n-1-j];
                matrix[n-1-i, n-1-j] = matrix[j, n-1-i];
                matrix[j, n-1-i] = temp;
            }
        }
    }
}
