public class Solution {
    public int MonotoneIncreasingDigits(int N) {
        var prev = 9;
        var pow = 1;
        var result = 0;
        while (N >= pow) {
            var digit = (N / pow) % 10;
            if (digit <= prev) {
                result += digit * pow;
            } else {
                result = (--digit) * pow + pow - 1;
            }
            prev = digit;
            pow *= 10;
        }
        
        return result;
    }
}
