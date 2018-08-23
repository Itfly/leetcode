public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        if (bits == null || bits.Length == 0 || bits[bits.Length - 1] == 1) {
            return false;
        }
        
        var i = 0;
        while (i < bits.Length - 1) {
            if (bits[i] == 1) {
                i += 2;
            } else {
                i++;
            }
        }
        
        return bits.Length - 1 == i;
    }
}
