public class Solution {
    public int KSimilarity(string A, string B) {   
        var visited = new HashSet<string>();
        var queue = new Queue<string>();
        var n = A.Length;
        queue.Enqueue(A);
        visited.Add(A);
        var result = 0;
        while (queue.Count > 0) {
            var size = queue.Count;
            while (size-- > 0) {
                var cur = queue.Dequeue();
                if (cur == B) {
                    return result;
                }
                
                var i = 0;
                while (cur[i] == B[i]) {
                    i++;
                }
                for (var j = i + 1; j < n; j++) {
                    if (cur[j] == B[j] || cur[i] != B[j]) {
                        continue;
                    }
                    var next = Swap(cur, i, j);
                    if (visited.Contains(next)) {
                        continue;
                    }
                    queue.Enqueue(next);
                    visited.Add(next);
                }
            }
            result++;
        }
        
        return -1;
    }
    
    private string Swap(string str, int i, int j) {
        var sb = new StringBuilder(str);
        var temp = sb[i];
        sb[i] = sb[j];
        sb[j] = temp;
        return sb.ToString();
    }

}
