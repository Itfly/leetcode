public class Solution {
    public int CountRangeSum(int[] nums, int lower, int upper) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        var n = nums.Length;
        var sums = new long[n + 1];
        for (var i = 0; i < n; i++) {
            sums[i + 1] = sums[i] + nums[i];
        }
        
        
        
        return MergeSort(sums, 0, n, lower, upper);
    }
    
    private int MergeSort(long[] sums, int low, int high, int lower, int upper) {
        if (low == high) {
            return 0;
        }
        
        var mid = low + (high - low) / 2;
        var count = MergeSort(sums, low, mid, lower, upper) + MergeSort(sums, mid + 1, high, lower, upper);
        
        var temp = new long[high - low + 1];
        var j = mid + 1;
        var k = mid + 1;
        var r = mid + 1;
        var t = 0;
        for (var i = low; i <= mid; i++) {
            while (k <= high && sums[k] - sums[i] < lower) {
                k++;
            }       
            while (j <= high && sums[j] - sums[i] <= upper) {
                j++;
            }
            
            while (r <= high && sums[r] <= sums[i]) {
                temp[t++] = sums[r++];
            }
            temp[t++] = sums[i];
            count += j - k;
        }
        
        while (r <= high) {
            temp[t++] = sums[r++];
        }
        
        Array.Copy(temp, 0, sums, low, temp.Length);
        
        return count;
    }
}
