public class Solution {
    public string RemoveDuplicateLetters(string s) {
        var letters = new int[26];
        var visited = new bool[26];
        foreach (var ch in s) {
            letters[ch - 'a']++;
        }
        
        var sb = new StringBuilder();
        foreach (var ch in s) {
            var index = ch - 'a';
            letters[index]--;
            if (visited[index]) {
                continue;
            }
            
            while (sb.Length > 0) {
                var lastChar = sb[sb.Length - 1];
                if (ch < lastChar && letters[lastChar - 'a'] > 0) {
                    visited[lastChar - 'a'] = false;
                    sb.Length--;
                } else {
                    break;
                }
            }
            
            sb.Append(ch);
            visited[index] = true;
        }
        
        return sb.ToString();
    }
}
