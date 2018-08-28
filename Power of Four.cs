public class Solution {
    public bool IsPowerOfFour(int num) {
        if (num == 0 || (num & (num - 1)) != 0) {
            return false;
        }
        
        var cnt = 0; // tailing zeros
        while ((num & 1) == 0) {
            num >>= 1;
            cnt++;
        }
        
        return (cnt & 1) == 0;
    }
}
