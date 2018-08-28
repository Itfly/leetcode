https://leetcode.com/problems/integer-replacement/discuss/87920/A-couple-of-Java-solutions-with-explanations

public class Solution {
    public int IntegerReplacement(int n) {
        if(n==int.MaxValue) return 32;
        
        var count = 0;
        while (n != 1) {
            if ((n & 1) == 0) {
                n >>= 1;
            } else if (n == 3 || ((n >> 1) & 1) == 0) {
                --n;
            } else {
                ++n;
            }
            ++count;
        }
        
        return count;
    }
}
