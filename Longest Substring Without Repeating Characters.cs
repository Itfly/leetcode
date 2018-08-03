public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }
        
        var map = Enumerable.Repeat(-1, 256).ToArray();
        
        var last = 0;
        map[s[0]] = 0;
        int len = 1;
        int max = 1;
        for (var i = 1; i < s.Length; i++) {
            var index = (int) s[i];
            if (map[index] == -1) {
                ++len;
            } else {
                if (last <= map[index]) {
                    len = i - map[index];
                    last = map[index] + 1;
                } else {
                    ++len;
                }
            }
            map[index] = i;
            max = Math.Max(max, len);
        }
        
        return max;
    }
}
