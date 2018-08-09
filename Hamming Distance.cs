public class Solution {
    public int HammingDistance(int x, int y) {
        var xor = x ^ y;
        var distance = 0;
        while (xor != 0) {
            xor &= xor - 1;
            distance++;
        }
        
        return distance;
    }
}
