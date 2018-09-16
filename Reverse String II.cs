public class Solution {
    public string ReverseStr(string s, int k) {
        if (string.IsNullOrEmpty(s)) {
            return s;
        }
        
        var n = s.Length;
        var i = 0;
        var chars = s.ToCharArray();
        while (i < n) {
            var j = i + k - 1;
            if (j >= n) {
                j = n - 1;
            }
            Reverse(chars, i, j);
            if (j == n - 1) {
                break;
            }
            
            i += 2*k;
            if (i >= n) {
                break;
            }
        }
        
        return new string(chars);
    }
    
    private void Reverse(char[] chs, int i, int j) {
        while (i < j) {
            var temp = chs[i];
            chs[i++] = chs[j];
            chs[j--] = temp;
        }
    }
}
