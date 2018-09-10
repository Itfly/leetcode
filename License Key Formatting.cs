public class Solution {
    public string LicenseKeyFormatting(string S, int K) {
        var sb = new StringBuilder();
        var i = S.Length - 1;
        while (i >= 0) {
            var cnt = 0;
            while (i >= 0 && cnt < K) {
                if (S[i] != '-') {
                    if (sb.Length > 0 && cnt == 0) {
                        sb.Insert(0, '-');
                    }
                    
                    sb.Insert(0, Char.ToUpper(S[i]));
                    cnt++;
                }
                i--;
            }
        }
        
        return sb.ToString();
    }
}
