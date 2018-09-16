public class Solution {
    public bool IsMonotonic(int[] A) {
        var asc = true;
        var desc = true;
        for (var i = 1; i < A.Length; i++) {
            asc = asc && (A[i] >= A[i - 1]);
            desc = desc && (A[i] <= A[i - 1]);
            
            if ((asc || desc) == false) {
                return false;
            }
        }
        
        return true;
    }
}
