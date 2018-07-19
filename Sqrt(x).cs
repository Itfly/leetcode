public class Solution {
    public int MySqrt(int x) {
        if (x <= 1) {
            return x;
        }
        
        var left = 0;
        var right = x;
        while ((right - left) > 1) {
            var mid = (left + right) / 2;
            var sqrt = x / mid;
            if (mid == sqrt) {
                return mid;
            } else if (mid > sqrt) {
                right = mid;
            } else {
                left = mid;
            }
        }
        
        return left;
    }
}
