public class Solution {
    public int NumberOfBoomerangs(int[,] points) {
        var result = 0;
        
        var map = new Dictionary<int, int>();
        var n = points.GetLength(0);
        for (var i = 0; i < n; i++) {
            for (var j = 0; j < n; j++) {
                if (i == j) continue;
                
                var a = points[i, 0] - points[j, 0];
                var b = points[i, 1] - points[j, 1];
                var dis = a*a + b*b;
                if (map.ContainsKey(dis)) {
                    map[dis]++;
                } else {
                    map[dis] = 1;
                }
            }
            
            foreach (var val in map.Values) {
                result += val * (val - 1);
            }
            
            map.Clear();
        }
        
        return result;
    }
}
