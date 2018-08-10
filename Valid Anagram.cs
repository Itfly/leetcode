public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        
        var map = new int[26];
        for (var i = 0; i < s.Length; i++) {
            ++map[s[i] - 'a'];
        }
        for (var i = 0; i < t.Length; i++) {
            if (--map[t[i] - 'a'] < 0) {
                return false;
            }
        }
        return true;
    }
}
