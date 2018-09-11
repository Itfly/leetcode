public class Solution {
    public int[] KthSmallestPrimeFraction(int[] A, int K) {
        var n = A.Length;
        var low = 0.0;
        var high = 1.0;
        while (low < high) {
            var mid = (low + high) / 2;
            var cnt = 0;
            var p = 0;
            var q = 1;
            
            // Set A[i] as the numerator, and A[j] denominator
            for (int i = 0, j = 1; i < n - 1; ++i) {
                // find the first A[j] that A[i] / A[j] <= mid
                while (j < n && A[i] > mid * A[j]) {
                    j++;
                }
                
                // break if j equal to n
                if (j == n) {
                    break;
                }
                
                cnt += n - j;
                
                // update p and q if A[i] / A[j] is larger than p / q
                if (p * A[j] < q * A[i]) {
                    p = A[i];
                    q = A[j];
                }
            }
            
            if (cnt == K) {
                return new int[] {p, q};
            } else if (cnt < K) {
                low = mid;
            } else {
                high = mid;
            }
        }
        
        return new int[] {};
    }
}
