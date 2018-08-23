public class Solution {
    public int TotalNQueens(int n) {
        var count = 0;
        TotalNQueens(n, new List<int>(), ref count);
        
        return count;
    }
    
    private void TotalNQueens(int n, IList<int> pos, ref int count) {
        if (pos.Count == n) {
            count++;
            return;
        }
        
        for (var i = 0; i < n; i++) {
            if (!IsValid(i, pos)) {
                continue;
            }
            
            pos.Add(i);
            TotalNQueens(n, pos, ref count);
            pos.RemoveAt(pos.Count - 1);
        }
    }
    
    private bool IsValid(int col, IList<int> pos) {
        var n = pos.Count;
        for (var i = 0; i < n; i++) {
            if (pos[i] == col || Math.Abs(col - pos[i]) == Math.Abs(n - i)) {
                return false;
            }
        }
        
        return true;
    }
}
