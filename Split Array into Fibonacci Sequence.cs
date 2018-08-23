public class Solution {
    public IList<int> SplitIntoFibonacci(string s) {
        var result = new List<int>();
        if (s == null || s.Length < 3) {
            return result;
        }
        
        Backtrack(result, s, 0);      
        return result;
    }
    
    private bool Backtrack(List<int> result, string s, int pos) {
        if (s.Length == pos && result.Count > 2) {
            return true;
        }
        
        for (var i = 1; i <= s.Length - pos; i++) {
            if (s[pos] == '0' && i != 1) {
                break;
            }
            
            var num = Convert.ToInt64(s.Substring(pos, i));
            if (num > int.MaxValue) {
                break;
            }
            
            if (result.Count >= 2 && num > result[result.Count-1] + result[result.Count-2]) {
                break;
            }
            
            if (result.Count < 2 || num == result[result.Count-1] + result[result.Count-2]) {
                result.Add((int) num);
                if (Backtrack(result, s, pos + i)) {
                    return true;
                }
                result.RemoveAt(result.Count - 1);
            }
        }
        
        return false;
    }
}
