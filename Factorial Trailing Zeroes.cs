public class Solution {
    public int TrailingZeroes(int n) {
        if (n < 5) {
            return 0;
        }
        
        var cnt = 0;
        
        long i = 5;
        while (n / i >= 1) {
            cnt += n / (int) i;
            i *= 5;
        }
        
        return cnt;
    }
}
