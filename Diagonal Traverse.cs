public class Solution {
    public int[] FindDiagonalOrder(int[,] matrix) {
        if (matrix.Length == 0) {
            return new int[0];
        }
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        var array = new int[m * n];
        int d = 0;
        int r = 0, c = 0;
        for (var i = 0; i < array.Length; i++) {
            array[i] = matrix[r,c];
            if ((r + c) % 2 == 0) {
                if (c == n - 1) {
                    r++;
                } else if (r == 0) {
                    c++;
                } else {
                    r--;
                    c++;
                }
            } else {
                if (r == m - 1) {
                    c++;
                } else if (c == 0) {
                    r++;
                } else {
                    r++;
                    c--;
                }
            }
        }
        
        return array;
    }
}
