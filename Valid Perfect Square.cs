public class Solution {
    public bool IsPerfectSquare(int num) {
        if (num == 1) {
            return true;
        }
        
        var low = 1;
        var high = num / 2;
        while (low <= high) {
            var mid = low + (high - low) / 2;
            long temp = (long) mid * mid;
            if (temp == num) {
                return true;
            } else if (temp > num) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        
        return false;
    }
}
