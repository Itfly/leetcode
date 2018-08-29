https://blog.csdn.net/weixin_38739799/article/details/80596691

public class Solution {
    public int ShortestPathLength(int[][] graph) {
         var n = graph.Length;
        var dis = Floyd(graph);
        var m = 1 << n;
        var dp = new int[m, graph.Length];
        for (var i = 0; i < n; i++) {
            for (var j = 0; j < m; j++) {
                dp[j, i] = n * n;
            }
        }
        for (var i = 0; i < n; i++) {
            dp[1 << i, i] = 0;
        }
        
        for (var j = 1; j < m; j++) {
            for (var i = 0; i < n; i++) {
                if ((j & (1 << i)) != 0) {  // the ith vertex is in the Set j 
                    for (var k = 0; k < n; k++) {
                        dp[j, i] = Math.Min(dp[j, i], dp[j ^ (1 << i), k] + dis[k, i]);
                    }
                }
            }
        }
        
        var result = int.MaxValue;
        for (var i = 0; i < n; i++) {
            result = Math.Min(result, dp[m - 1, i]);
        }
        
        return result;
    }
    
    private int[,] Floyd(int[][] graph) {
        var n = graph.Length;
        var dis = new int[n, n];
        for (var i = 0; i < n; i++) {
            for (var j = 0; j < n; j++) {
                if (i != j) {
                    dis[i, j] = n * n;
                }
            }
        }
        
        for (var i = 0; i < n; i++) {
            foreach (var j in graph[i]) {
                dis[i, j] = 1;
                dis[j, i] = 1;
            }
        }
        
        for (var k = 0; k < n; k++) {
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < n; j++) {
                    if (k != i && k != j) {
                        dis[i, j] = Math.Min(dis[i, j], dis[i, k] + dis[k, j]);
                    }
                }
            }
        }
        
        return dis;
    }
}
