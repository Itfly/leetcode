public class Solution {
    public int CountNumbersWithUniqueDigits(int n) {
        if (n == 0) {
            return 1;
        }
        if (n > 10) {
            return 0;
        }
        
        var result = 10;
        var dp = 9;
        var availableNumber = 9;
        while (n-- > 1) {
            dp *= availableNumber--;
            result += dp;
        }
        
        return result;
    }
}
