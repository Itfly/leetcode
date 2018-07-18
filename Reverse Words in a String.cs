public class Solution {
    public string ReverseWords(string s) {
        if (s == null || s.Length == 0) {
            return "";
        }
        
        var strs = s.Split(null);
        var sb = new StringBuilder();
        for (var i = strs.Length - 1; i >= 0; i--) {
            if (strs[i] != "") {
                sb.Append(strs[i]).Append(" ");
            }
        }
        
        return sb.ToString().Trim();
    }
}
