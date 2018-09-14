public class Solution {
    public IList<string> LetterCasePermutation(string S) {
        var result = new List<string>();
        DFS(S, result, 0);
        
        return result;
    }
    
    private void DFS(string s, List<string> result, int i) {
        if (i == s.Length) {
            result.Add(s);
            return;
        }
        
        if (!char.IsLetter(s[i])) {
            DFS(s, result, i + 1);
            return;
        }
        
        var sb = new StringBuilder(s);
        sb[i] =  char.ToLower(sb[i]);
        DFS(sb.ToString(), result, i + 1);
        
        sb[i] = char.ToUpper(sb[i]);
        DFS(sb.ToString(), result, i + 1);
    }
}
