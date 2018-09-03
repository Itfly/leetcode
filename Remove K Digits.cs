public class Solution {
    public string RemoveKdigits(string num, int k) {
        if (string.IsNullOrEmpty(num)) {
            return num;
        }
        if (num.Length == k) {
            return "0";
        }
        
        var chs = new char[num.Length];
        var last = -1;
        for (var i = 0; i < num.Length; i++) {
            var ch = num[i];
            while (k > 0 && last >= 0 && chs[last] > ch) {
                last--;
                k--;
            }
            chs[++last] = ch;
        }
        
        var start = 0;
        while (start <= last && chs[start] == '0') {
            start++;
        }
        
        return start == (last + 1) ? "0" : new string(chs, start, last - start + 1 - k);
    }
}
