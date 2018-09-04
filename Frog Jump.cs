public class Solution {
    public bool CanCross(int[] stones) {
        if (stones == null || stones.Length == 0) {
            return false;
        } 
        if (stones.Length == 1) {
            return true;
        }
        if (stones[1] != 1) {
            return false;
        }
        if (stones.Length == 2) {
            return true;
        }
        
        var end = stones[stones.Length - 1];
        var map = new HashSet<int>();
        var visited = new Dictionary<Tuple<int, int>, bool>();
        for (var i = 0; i < stones.Length; i++) {
            if (i > 3 && stones[i] > stones[i - 1] * 2) {
                return false;
            }
            map.Add(stones[i]);
        }
        
        return CanCross(map, visited, end, 1, 1);
    }
    
    private bool CanCross(HashSet<int> map, Dictionary<Tuple<int, int>, bool> visited, int end, int pos, int k) {
        if (pos == end) {
            return true;
        }
        var tuple = new Tuple<int, int>(pos, k);
        if (visited.ContainsKey(tuple)) {
            return visited[tuple];
        }
        
        for (var i = k - 1; i <= k + 1; i++) {
            if (i > 0 && map.Contains(pos + i) && CanCross(map, visited, end, pos + i, i)) {
                visited[tuple] = true;
                return true;
            }
        }

        visited[tuple] = false;
        return false;
    }
}
