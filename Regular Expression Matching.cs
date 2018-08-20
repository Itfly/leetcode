public class Solution {
    public bool IsMatch(string s, string p) {
        return IsMatch(s, p, 0, 0);
    }
    
    private bool IsMatch(string s, string p, int i, int j) {
        if (j == p.Length) {
            return i == s.Length;
        }
        
        
        if (j < p.Length - 1 && p[j + 1] == '*') {
            return (i < s.Length && s[i] == p[j] || p[j] == '.' && i != s.Length) && IsMatch(s, p, i + 1, j) || IsMatch(s, p, i, j + 2);
        } else {
            return (i < s.Length && s[i] == p[j] || p[j] == '.' && i != s.Length) && IsMatch(s, p, i + 1, j + 1);
        }
    }
}
