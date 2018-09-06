public class Solution {
    private static readonly char[] chars = new char[] {'A', 'C', 'G', 'T'}; 
    public int MinMutation(string start, string end, string[] bank) {
        if (start == end) {
            return 0;
        }
        
        var visited = new Dictionary<string, bool>();
        visited[start] = true;
        foreach (var gene in bank) {
            visited[gene] = false;
        }
        
        var queue = new Queue<(string mutation, int step)>();
        queue.Enqueue((start, 0));
        while (queue.Count > 0) {
            var cur = queue.Dequeue();
            if (cur.mutation == end) {
                return cur.step;
            }
            
            for (var i = 0; i < 8; i++) {
                foreach (var ch in chars) {
                    var sb = new StringBuilder(cur.mutation);
                    sb[i] = ch;
                    var temp = sb.ToString();
                    if (visited.ContainsKey(temp) && visited[temp] == false) {
                        visited[temp] = true;
                        queue.Enqueue((temp, cur.step + 1));
                    }
                }
            }
        }
                      
        return -1;
    }
}
