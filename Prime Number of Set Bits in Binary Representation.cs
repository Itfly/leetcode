public class Solution {
    private static readonly int[] primes = new int[] {2, 3, 5, 7, 11, 13, 17, 19};
    
    public int CountPrimeSetBits(int L, int R) {
        var result = 0;
        for (var i = L; i <= R; i++) {
            var count = CountSetBits(i);
            if (primes.Contains(count)) {
                result++;
            }
        }
        
        return result;
    }
    
    private int CountSetBits(int num) {
        var count = 0;
        while (num != 0) {
            num &= num - 1;
            count++;
        }
        
        return count;
    }
}
