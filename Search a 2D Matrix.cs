public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        if (matrix == null || matrix.Length == 0) {
            return false;
        }
        
        var low = 0;
        var high = matrix.Length - 1;
        while (low <= high) {
            var mid = low + (high - low) / 2;
            var i = mid / matrix.GetLength(1);
            var j = mid % matrix.GetLength(1);
            if (matrix[i, j] == target) {
                return true;
            } else if (matrix[i, j] > target) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        
        return false;
    }
}
