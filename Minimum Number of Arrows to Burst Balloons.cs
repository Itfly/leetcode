public class Solution {
    public int FindMinArrowShots(int[,] points) {
        if (points == null || points.Length == 0) {
            return 0;
        }
        
        var arrays = ToJagged(points);
        Array.Sort(arrays, (x, y) => x[1] - y[1]);
        var result = 1;
        var last = arrays[0][1];
        for (var i = 1; i < arrays.Length; i++) {
            if (arrays[i][0] <= last) {
                continue;
            }
            
            result += 1;
            last = arrays[i][1];
        }
        
        return result;
    }
    
    private int[][] ToJagged(int[,] points) {
        var m = points.GetLength(0);
        var n = points.GetLength(1);
        var arrays = new int[m][];
        for (var i = 0; i < m; i++) {
            arrays[i] = new int[n];
            for (var j = 0; j < n; j++) {
                arrays[i][j] = points[i, j];
            }
        }
        
        return arrays;
    }
}

// TODO: use this one : http://www.cnblogs.com/grandyang/p/6050562.html