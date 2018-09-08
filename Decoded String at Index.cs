public class Solution {
    public string DecodeAtIndex(string S, int K) {
        long n = 0;
        var i = 0;
        for (i = 0; n < K; i++) {
            n = char.IsDigit(S[i]) ? (n * (S[i] - '0')) : n + 1;
        }
        while (i-- >= 0) {
            if (char.IsDigit(S[i])) {
                n /= (S[i] - '0');
                K = (int) (K % n);
            } else {
                if (K % n == 0) {
                    return S[i].ToString();
                }
                n--;
            }
        }
        
        return null;
    }
}
