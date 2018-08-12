public class Solution {
    public int TitleToNumber(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }
        
        var num = 0;
        foreach (var ch in s) {
            num = num * 26 + ch - 'A' + 1;
        }
        return num;
    }
}
