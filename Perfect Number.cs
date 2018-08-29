public class Solution {
    public bool CheckPerfectNumber(int num) {
        if (num == 1) {
            return false;
        }
        
        var sum = 1;
        for (var i = 2; i <= Math.Sqrt(num); i++) {
            if (num % i == 0) {
                sum += i + num / i;
            }
        }
        
        return sum == num;
    }
}
