public class Solution {
    public int FindCircleNum(int[,] M) {
        var num = 0;
        for (var i = 0; i < M.GetLength(0); i++) {
            num += FindOneCircle(M, i);
        }
        
        return num;
    }
    
    private int FindOneCircle(int[,] M, int x) {
        if (M[x, x] == 0) {
            return 0;
        }
        
        var queue = new Queue<int>();
        queue.Enqueue(x);
        while (queue.Count > 0) {
            var size = queue.Count;
            for (var i = 0; i < size; i++) {
                var cur = queue.Dequeue();
                for (var j = 0; j < M.GetLength(0); j++) {
                    if (M[j, j] == 1 && M[cur, j] == 1) {
                        queue.Enqueue(j);
                        M[j, j] = 0;
                    }  
                }
            }
        }
        
        return 1;
    }
}
