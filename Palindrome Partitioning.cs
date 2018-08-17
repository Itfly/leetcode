public class Solution {
    public IList<IList<string>> Partition(string s) {
        var palindromics = CalculatePalindromic(s);
        //return Partition(s, 0, palindromics);
        
        // use backtracking
        var results = new List<IList<string>>();
        var result = new List<string>();
        BackTrack(s, 0, palindromics, results, result);
        return results;
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
    
    private void BackTrack(string s, int i, bool[,] palindromics, IList<IList<string>> results, IList<string> result) {
        if (i >= s.Length && result.Count > 0) {
            results.Add(new List<string>(result));
        }
        
        for (var j = i; j < s.Length; j++) {
            if (!palindromics[i,j]) {
                continue;
            }
            
            var sub = s.Substring(i, j - i + 1);
            result.Add(sub);
            BackTrack(s, j + 1, palindromics, results, result);
            result.RemoveAt(result.Count - 1);
        }
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
