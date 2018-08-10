public class Solution {
    public string CountAndSay(int n) {
        var str = "";
        for (var i = 0; i < n; i++) {
            str = GetNextCount(str);
        }
        
        return str;
    }
    
    private string GetNextCount(string str) {
        if (str == "") {
            return "1";
        }
        
        var sb = new StringBuilder();
        for (var i = 0; i < str.Length; i++) {
            var ch = str[i];
            var cnt = 1;
            while (i < str.Length - 1 && ch == str[i + 1]) {
                cnt++;
                i++;
            }
            sb.Append((char) (cnt + '0')).Append(ch);
        }
        return sb.ToString();
    }
}
