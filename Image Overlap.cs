public class Solution {
    public int LargestOverlap(int[][] A, int[][] B) {
        var n = A.Length;
        var counts = new int[2*n, 2*n];
        var result = 0;
        for (var i = 0; i < n; i++) {
            for (var j = 0; j < n; j++) {
                if (A[i][j] == 1) {
                    for (var p = 0; p < n; p++) {
                        for (var q = 0; q < n; q++) {
                            if (B[p][q] == 1) {
                                counts[n + p - i, n + q - j]++;
                                result = Math.Max(result, counts[n + p - i, n + q - j]);    
                            }
                        }
                    }
                }
            }
        }
        
        return result;
    }
}
