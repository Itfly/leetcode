public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        if (matrix.GetLength(0) == 0) {
            return new List<int>(0);
        }
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        var list = new List<int>(m * n); 
        int k = 0, l = 0;
        while (k < m && l < n) {
            for (var i = l; i < n; i++) {
                list.Add(matrix[k,i]);
            }
            k++;
            
            for (var i = k; i < m; i++) {
                list.Add(matrix[i,n-1]);
            }
            n--;
            
            if (k < m) {
                for (var i = n - 1; i >= l; i--) {
                    list.Add(matrix[m-1,i]);
                }
                m--;
            }
            
            if (l < n) {
                for (var i = m-1; i >= k; i--) {
                    list.Add(matrix[i,l]);
                }
                l++;
            }
        }
        
        return list;
    }
}

  
