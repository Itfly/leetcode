public class Solution {
    public IList<IList<string>> Partition(string s) {
        var palindromics = CalculatePalindromic(s);
        return Partition(s, 0, palindromics);
    }
    
    private bool[,] CalculatePalindromic(string s) {
        var palindromics = new bool[s.Length,s.Length];
        for (var i = 0; i < s.Length; i++) {
            palindromics[i, i] = true;
        }
        
        for (var k = 1; k < s.Length; k++) {
            for (var i = 0; i < s.Length - k; i++) {
                var j = i + k;
                palindromics[i, j] = (s[i] == s[j] && (j - i <= 2 || palindromics[i + 1, j - 1]));
            }
        }
        
        return palindromics;
    }
    
    private IList<IList<string>> Partition(string s, int i, bool[,] palindromics) {
        var results = new List<IList<string>>();
        if (s.Length == i) {
            results.Add(new List<string>());
            return results;
        }
        
        for (var j = i; j < s.Length; j++) {
            if (!palindromics[i,j]) {
                continue;
            }
            
            var temps = Partition(s, j + 1, palindromics);
            var sub = s.Substring(i, j - i + 1);
            foreach (var temp in temps) {
                var result = new List<string>() {sub};
                result.AddRange(temp);
                results.Add(result);
            }
        }
        
        return results;
    }
}
