public class Solution {
    public int Reverse(int x) {
        var positived = true;
        if (x < 0) {
            positived = false;
            x = -x;
        }
        
        long reversed = 0;
        while (x > 0) {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        
        reversed = positived ? reversed : -reversed;
        if (reversed > int.MaxValue || reversed < int.MinValue) {
            reversed = 0;
        }
        return (int) reversed;
    }
}
