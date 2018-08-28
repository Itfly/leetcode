public class Solution {
    public int CountSegments(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }
        
        var space = ' ';
        var count = 0;
        for (var i = 0; i < s.Length; i++) {
            while (i < s.Length && s[i] == space) {
                i++;
            }
            if (i == s.Length) {
                break;
            }
            
            while (++i < s.Length && s[i] != space);
            
            count++;
        }
        
        return count;
    }
}
