public class Solution {
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D) {
        var map = new Dictionary<int, int>();
        foreach (var a in A) {
            foreach (var b in B) {
                var temp = a + b;
                if (map.ContainsKey(temp)) {
                    ++map[temp];
                } else {
                    map[temp] = 1;
                }
            }
        }
        
        var res = 0;
        foreach (var c in C) {
            foreach (var d in D) {
                var target = -1 * (c + d);
                if (map.ContainsKey(target)) {
                    res += map[target];    
                }
            }
        }
        
        return res;
    }
}
