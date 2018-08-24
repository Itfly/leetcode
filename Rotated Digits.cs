public class Solution {
    public int RotatedDigits(int N) {
        var count = 0;
        for (var i = 1; i <= N; i++) {
            if (IsGood(i)) {
                count++;
            }
        }
        
        return count;
    }
    
    private static readonly int[] rotates = new int[] {2,5,6,9};
    private static readonly int[] invalids = new int[] {3,4,7};
    private bool IsGood(int N) {
        var mayValid = false;
        while (N > 0) {
            var mod = N % 10;
            if (invalids.Contains(mod)) {
                return false;
            }
            if (rotates.Contains(mod)) {
                mayValid = true;
            }
            
            N = N / 10;
        }
        
        return mayValid;
    }
}
