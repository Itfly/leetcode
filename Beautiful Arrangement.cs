public class Solution {
    public int CountArrangement(int N) {
        if (N == 0) {
            return 0;
        }
        
        var count = 0;
        DFS(N, 1, new bool[N + 1], ref count);
        
        return count;
    }
    
    private void DFS(int n, int i, bool[] visited, ref int count) {
        if (i > n) {
            count++;
            return;
        }
        
        for (var num = 1; num <= n; num++) {
            if (visited[num] == false && (num % i == 0 || i % num == 0)) {
                visited[num] = true;
                DFS(n, i + 1, visited, ref count);
                visited[num] = false;
            }
        }
    }
}
