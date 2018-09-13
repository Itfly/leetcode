public class Solution {
    private static readonly int[][] dirs = 
        new int[6][] {
            new int[] {1, 3}, 
            new int[] {0, 2, 4}, 
            new int[] {1, 5}, 
            new int[] {0, 4}, 
            new int[] {1, 3, 5}, 
            new int[] {2, 4}
        };
    
    public int SlidingPuzzle(int[,] board) {
        var target = "123450";
        var start = "";
        for (var i = 0; i < board.GetLength(0); i++) {
            for (var j = 0; j < board.GetLength(1); j++) {
                start += board[i, j];
            }
        }
        
        var visited = new HashSet<string>();
        var queue = new Queue<string>();
        queue.Enqueue(start);
        visited.Add(start);
        var result = 0;
        while (queue.Count > 0) {
            var size = queue.Count;
            while (size-- > 0) {
                var cur = queue.Dequeue();
                if (cur == target) {
                    return result;
                }
                
                var index = cur.IndexOf('0');
                foreach (var dir in dirs[index]) {
                    var next = SwapZero(cur, index, dir);
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
    
    private string SwapZero(string str, int i, int j) {
        var sb = new StringBuilder(str);
        sb[i] = sb[j];
        sb[j] = '0';
        return sb.ToString();
    }
}
