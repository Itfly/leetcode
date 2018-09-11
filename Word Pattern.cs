public class Solution {
    public bool WordPattern(string pattern, string str) {
        if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(str)) {
            return false;
        }
        
        var words = str.Split();
        if (pattern.Length != words.Length) {
            return false;
        }
        
        var map1 = new Dictionary<char, string>();
        var map2 = new Dictionary<string, char>();
        for (var i = 0; i < pattern.Length; i++) {
            if (map1.ContainsKey(pattern[i])) {
                if (map1[pattern[i]] != words[i]) {
                    return false;
                }
            } else {
                map1[pattern[i]] = words[i];
            }
            
            if (map2.ContainsKey(words[i])) {
                if (map2[words[i]] != pattern[i]) {
                    return false;
                }
            } else {
                map2[words[i]] = pattern[i];
            }
        }
        
        return true;
    }
}
