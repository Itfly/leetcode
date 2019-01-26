public class Solution {
    // http://www.cnblogs.com/grandyang/p/6087347.html
    public bool RepeatedSubstringPattern(string s) {
        var kmp = new int[s.Length];
        var i = 1;
        var j = 0;
        while (i < s.Length) {
            if (s[i] == s[j]) {
                kmp[i++] = ++j;
            } else if (j == 0) {
                ++i;
            } else {
                j = kmp[j - 1];
            }
        }
        
        return kmp[s.Length - 1] > 0 && s.Length % (s.Length - kmp[s.Length - 1]) == 0;
    }
}

public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        var ss = s + s;
        return ss.Substring(1, ss.Length - 2).Contains(s);
    }
}
