public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) {
            return "";
        }
        
        var pos = strs[0].Length;
        for (var i = 1; i < strs.Length; i++) {
            for (var j = 0; j < pos; j++) {
                if (j == strs[i].Length) {
                    pos = j;
                    break;
                }
                
                if (strs[i][j] != strs[0][j]) {
                    pos = j;
                    break;
                }
            }
            
        }
        return strs[0].Substring(0, pos);
    }
}
