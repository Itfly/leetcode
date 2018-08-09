public class Solution {
    public int CountPrimes(int n) {
        if (n <= 1) {
            return 0;
        }
        
        var primes = new bool[n];
        for (var i = 2; i < n; i++) {
            primes[i] = true;
        }
        
        for (var i = 2; i <= Math.Sqrt(n - 1); i++) {
            if (primes[i]) {
                for (var j = i + i; j < n; j += i) {
                    primes[j] = false;
                }
            }
        }
        
        var count = 0;
        for (var i = 0; i < n; i++) {
            if (primes[i]) {
                ++count;
            }
        }
        
        return count;
    }
}
