public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var results = new List<string>();
        GenerateParenthesis(results, "", 0, 0, n);
        
        return results;
    }
    
    private void GenerateParenthesis(IList<string> results, string parenthes, int l, int r, int n) {
        if (l == n) {
            results.Add(parenthes + new String(')', n - r));
            return;
        }
        
        GenerateParenthesis(results, parenthes + '(', l + 1, r, n);
        if (r < l) {
            GenerateParenthesis(results, parenthes + ')', l, r + 1, n);
        }
    }
}
