public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var map1 = new int[256];
        var map2 = new int[256];
        for (var i = 0; i < s.Length; i++) {
            if (map1[(int) s[i]] != map2[(int) t[i]]) {
                return false;
            }
            
            map1[(int) s[i]] = i + 1;
            map2[t[i]] = i + 1;
        }
        return true;
    }
}
