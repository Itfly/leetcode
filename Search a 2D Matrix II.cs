public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        var i = 0; 
        var j = matrix.GetLength(1) - 1;
        while (i < matrix.GetLength(0) && j >= 0) {
            if (matrix[i, j] == target) {
                return true;
            } else if (matrix[i, j] < target) {
                i++;
            } else {
                j--;
            }
        }
        
        return false;
    }
}
