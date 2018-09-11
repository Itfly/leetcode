public class Solution {
    public int HIndex(int[] citations) {
        if (citations == null || citations.Length == 0) {
            return 0;
        }
        
        var n = citations.Length;
        var h = new int[n + 1];
        foreach (var citation in citations) {
            if (citation >= n) {
                h[n]++;
            } else {
                h[citation]++;
            }
        }
        
        var sum = 0;
        for (var i = n; i >= 0; i--) {
            sum += h[i];
            if (sum >= i) {
                return i;
            }
        }
        
        return 0;
    }
}
