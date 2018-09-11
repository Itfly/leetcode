public class Solution {
    public int FindNthDigit(int n) {
        var len = 1;
        var count = 9L;
        var start = 1;
        while (n > len * count) {
            n -= (int) (len * count);
            len++;
            count *= 10;
            start *= 10;
        }
        start += (n - 1) / len;
        
        return start.ToString()[(n - 1) % len] - '0';
    }
}
