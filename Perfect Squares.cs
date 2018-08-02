public class Solution {
    // BFS
    public int NumSquares(int n) {
        var up = (int) Math.Floor(Math.Sqrt(n));
        var squares = new List<int>(up);
        for (int i = 1; i <= up; i++) {
            squares.Add(i * i);
        }
        
        var visited = new bool[n + 1];
        var q = new Queue<int>();
        q.Enqueue(0);
        visited[0] = true;
        var steps = 0;
        while (q.Count > 0) {
            ++steps;
            int size = q.Count;
            while (size-- > 0) {
                var cur = q.Dequeue();
                foreach (var square in squares) {
                    var next = cur + square;
                    if (next == n) {
                        return steps;
                    } 
                        
                    if (next < n && !visited[next]) {
                        q.Enqueue(next);
                        visited[next] = true;
                    } else if (next > n) {
                        break;
                    }
                }
            }
        }
        
        return -1;
    }
}
