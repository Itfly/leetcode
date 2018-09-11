public class Solution {
    public int HIndex(int[] citations) {
        if (citations == null || citations.Length == 0) {
            return 0;
        }
        
        var low = 0;
        var high = citations.Length - 1;
        while (low <= high) {
            var mid = low + (high - low) / 2;
            var h = citations.Length - mid;
            if (citations[mid] == h) {
                return h;
            } else if (citations[mid] > h) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        
        return citations.Length - low;  
    }
}
