public class Solution {
    public int Divide(int dividend, int divisor) {
        if (divisor == 0) {
            return int.MaxValue;
        }
        if (divisor == -1 && dividend == int.MinValue) {
            return int.MaxValue;
        }
        
        long dividendL = Math.Abs((long) dividend);
        long divisorL = Math.Abs((long) divisor);
        
        var result = 0;
        while (dividendL >= divisorL) {
            var shift = 0;
            while (dividendL >= (divisorL << (shift + 1))) {
                shift++;
            }
                   
            result += 1 << shift;
            dividendL -= divisorL << shift;
        }
                   
        if (dividend > 0 && divisor > 0 || dividend < 0 && divisor < 0) {
            return result;
        } else {
            return -result;
        }
    }
}
