public class Solution {
    public int RangeBitwiseAnd(int m, int n) {
        if (m == 0) {
            return 0;
        }
        
        var factor = 0;
        while (m != n) {
            m >>= 1;
            n >>= 1;
            factor++;
        }
        
        return m << factor;
    }
}
