public class Solution {
    public int KthSmallest(int[,] matrix, int k) {
        var n = matrix.GetLength(0);
        var low = matrix[0, 0];
        var upper = matrix[n - 1, n - 1];
        
        while (low < upper) {
            var mid = low + (upper - low) / 2;
            var cnt = Count(matrix, mid);
            if (cnt < k) {
                low = mid + 1;
            } else {
                upper = mid;
            }
        }
        
        return upper;
    }
    
    private int Count(int[,] matrix, int target) {
        var n = matrix.GetLength(0);
        var i = 0;
        var j = n - 1;
        var cnt = 0;
        while (i < n && j >= 0) {
            if (matrix[i, j] <= target) {
                cnt += j + 1;
                i++;
            } else {
                j--;
            }
        }
        
        return cnt;
    }
}
