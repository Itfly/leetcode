public class Solution {
    public int FirstUniqChar(string s) {
        var map = new int[256];
        foreach (var ch in s) {
            ++map[ch];
        }
        for (var i = 0; i < s.Length; i++) {
            if (map[s[i]] == 1) {
                return i;
            }
        }
        return -1;
    }
}
