public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        var result = new List<IList<string>>();
        SolveNQueens(n, new List<string>(), result);
        
        return result;
    }
    
    private void SolveNQueens(int n, IList<string> rows, IList<IList<string>> result) {
        if (rows.Count == n) {
            result.Add(new List<string>(rows));
            return;
        }
        
        for (var i = 0; i < n; i++) {
            if (!IsValid(i, rows)) {
                continue;
            }
            
            var chs = Enumerable.Repeat('.', n).ToArray();
            chs[i] = 'Q';
            
            rows.Add(new string(chs));
            SolveNQueens(n, rows, result);
            rows.RemoveAt(rows.Count - 1);
        }
    }
    
    private bool IsValid(int col, IList<string> rows) {
        var n = rows.Count;
        for (var i = 0; i < n; i++) {
            var j = rows[i].IndexOf('Q');
            if (j == col) {
                return false;
            }
            
            if (Math.Abs(col - j) == Math.Abs(n - i)) {
                return false;
            }
        }
        
        return true;
    }
}
