public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(t) || string.IsNullOrEmpty(s)) {
            return "";
        }
        
        var counts = new int[256];
        foreach (var ch in t) {
            counts[ch]++;
        }
        
        var start = 0;
        var covers = new int[256];
        var cnt = 0;
        var minWin = s.Length;
        var minBeg = 0;
        for (var i = 0; i < s.Length; i++) {
            var ch = (int) s[i];
            if (counts[ch] == 0) {
                continue;
            }
            
            covers[ch]++;
            if (covers[ch] <= counts[ch]) {
                cnt++;
            }
            
            if (cnt == t.Length) {
                while (covers[s[start]] == 0 || covers[s[start]] > counts[s[start]]) {
                    if (covers[s[start]] != 0) {
                        covers[s[start]]--;
                    }
                    
                    start++;
                }
                
                if (minWin > i - start + 1) {
                    minWin = i - start + 1;
                    minBeg = start;
                }
            }
        }
        
        if (cnt < t.Length) {
            return "";
        } else {
            return s.Substring(minBeg, minWin);
        }
    }
}
