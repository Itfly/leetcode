public class Solution {
    public int FindLength(int[] A, int[] B) {
        if (A == null || B == null || A.Length == 0 || B.Length == 0) {
            return 0;
        }
        
        var max = 0;
        var dp = new int[A.Length + 1, B.Length + 1];
        for (var i = 1; i <= A.Length; i++) {
            for (var j = 1; j <= B.Length; j++) {
                if (A[i-1] != B[j-1]) {
                    continue;
                }
                
                dp[i, j] = dp[i-1, j-1] + 1;
                max = Math.Max(max, dp[i,j]);
            }
        }
        
        return max;
    }
}
