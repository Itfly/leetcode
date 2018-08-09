public class Solution {
// https://www.geeksforgeeks.org/write-an-efficient-c-program-to-reverse-bits-of-a-number/
    public uint reverseBits(uint n) {
        var reversed = n;
        var size = 31;
        n >>= 1;
        while (n > 0) {
            reversed <<= 1;
            reversed |= n & 1;
            n >>= 1;
            --size;
        }
        reversed <<= size;
        return reversed;
    }
}
