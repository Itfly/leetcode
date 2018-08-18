public class Solution {
    public bool IsMatch(string s, string p) {
        if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(p)) {
            return true;
        }
        
        var i = 0;
        var j = 0;
        var starS = -1;
        var starP = -1;
        while (i < s.Length) {
            if (j < p.Length && (p[j] == '?' || s[i] == p[j])) {
                i++;
                j++;
            } else if (j < p.Length && p[j] == '*') {
                // skip continuous '*'
                while (j < p.Length && p[j] == '*') {
                    j++;
                }
                
                if (j == p.Length) {
                    return true;
                }
                
                // record current star's j and i index.
                starP = j;
                starS = i;
            } else {
                if (starS == -1) {
                    return false;
                }
                
                j = starP; // back to the star's index.
                i = ++starS;
            }
        }
        
        while (j < p.Length && p[j] == '*') {
            j++;
        }
        return j == p.Length;
    }
}
