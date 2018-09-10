public class Solution {
    public int LongestSubstring(string s, int k) {
        if (k <= 1) {
            return s.Length;
        }
        
        return LongestSubstring(s, 0, s.Length, k);
    }
    
    private int LongestSubstring(string s, int low, int high, int k) {
        if (high - low < k) {
            return 0;
        }
        
        var repeats = new int[26];
        for (var i = low; i < high; i++) {
            repeats[s[i] - 'a']++;
        }
        
        for (var i = low; i < high; i++) {
            if (repeats[s[i] - 'a'] < k) {
                return Math.Max(LongestSubstring(s, low, i, k), LongestSubstring(s, i + 1, high, k));
            }
        }
        
        return high - low;
    }
}
