public class Solution {
    public IList<int> GrayCode(int n) {
        if (n == 0) {
            return new List<int> {0};
        }
        
        var result = GrayCode(n - 1);
        var added = 1 << (n - 1);
        for (var i = result.Count - 1; i >= 0; i--) {
            result.Add(result[i] + added);
        }
        
        return result;
    }
}
