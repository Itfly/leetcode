public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        var result = new List<string>();
        Helper(s, new StringBuilder(), 0, 0, result);
        
        return result;
    }
    
    private void Helper(string s, StringBuilder ip, int i, int step, IList<string> result) {
        if ((s.Length - i) > (4 - step) * 3 || (s.Length - i) < (4 - step)) {
            return;
        }
        
        if (s.Length == i && step == 4) {
            ip.Length--;
            result.Add(ip.ToString());
        }
        
        var num = 0;
        for (var j = i; j < i + 3 && j < s.Length; j++) {
            num = num * 10 + s[j] - '0';
            if (num < 256) {
                ip.Append(s[j]);
                var sb = new StringBuilder();
                sb.Append(ip).Append('.');
                Helper(s, sb, j + 1, step + 1, result);
            }
            
            if (num == 0) {
                break;
            }
        }
    }
}
