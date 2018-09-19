public class Solution {
    public int[] FindRedundantConnection(int[,] edges) {
        var parent = new int[1001];
        for (var i = 1; i < parent.Length; i++) {
            parent[i] = i;
        }
        
        for (var i = 0; i < edges.GetLength(0); i++) {
            var u = edges[i, 0];
            var v = edges[i, 1];
            if (find(parent, u) == find(parent, v)) {
                return new int[] {u, v};
            } else {
                parent[find(parent, u)] = find(parent, v);
            }
        }
        
        return new int[2];
    }
    
    private int find(int[] parent, int node) {
        if (node != parent[node]) {
            parent[node] = find(parent, parent[node]);
        }
        
        return parent[node];
    }
}
