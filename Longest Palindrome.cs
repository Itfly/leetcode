public class Solution {
    public int LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }
        
        var map = new Dictionary<char, int>();
        foreach (var ch in s) {
            if (map.ContainsKey(ch)) {
                map[ch]++;
            } else {
                map[ch] = 1;
            }
        }
        
        var hasSingle = false;
        var result = 0;
        foreach (var val in map.Values) {
            if (val % 2 == 0) {
                result += val;
            } else {
                result += val - 1;
                hasSingle = true;
            }
        }
        
        return hasSingle ? result + 1 : result;
    }
}
