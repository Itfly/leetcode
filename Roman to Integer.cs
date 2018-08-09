public class Solution {
    private static readonly Dictionary<char, int> map = new Dictionary<char, int> {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    
    public int RomanToInt(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }
        
        var sum = map[s[0]];
        for (var i = 1; i < s.Length; i++) {
            if (map[s[i]] <= map[s[i - 1]]) {
                sum += map[s[i]];
            } else {
                sum += map[s[i]] - 2 * map[s[i - 1]];
            }
        }
        
        return sum;
    }
}
