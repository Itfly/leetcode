public class Solution {
    public bool IsMonotonic(int[] A) {
        var asc = false;
        var desc = false;
        for (var i = 1; i < A.Length; i++) {
            if (A[i] > A[i - 1]) {
                asc = true;
            }
            if (A[i] < A[i - 1]) {
                desc = true;
            }
            if (asc && desc) {
                return false;
            }
        }
        
        return true;
    }
}
