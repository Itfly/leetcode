public class Solution {
    // O(n^2)
    public int LengthOfLIS(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }    
        
        var lens = new int[nums.Length];
        var max = 1;
        for (var i = 0; i < nums.Length; i++) {
            lens[i] = 1;
            for (var j = 0; j < i; j++) {
                if (nums[i] > nums[j]) {
                    lens[i] = Math.Max(lens[i], lens[j] + 1);
                }
            }
            max = Math.Max(max, lens[i]);
        }
        
        return max;
    }
    
    // O(NlogN)
    // https://www.felix021.com/blog/read.php?1587
    // https://www.programcreek.com/2014/04/leetcode-longest-increasing-subsequence-java/
    public int LengthOfLIS(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }    
        
        var ends = new int[nums.Length];
        var maxLen = 1;
        ends[0] = nums[0];
        for (var i = 1; i < nums.Length; i++) {
           if (nums[i] > ends[maxLen - 1]) {
               ends[maxLen++] = nums[i];
           } else {
               var pos = BinarySearch(ends, nums[i], maxLen);
               ends[pos] = nums[i];
           }
        }
        
        return maxLen;
    }
    
    private int BinarySearch(int[] nums, int value, int n) {
        var low = 0;
        var high = n - 1;
        while (low <= high) {
            var mid = low + (high - low) / 2;
            if (nums[mid] == value) {
                return mid;
            } else if (nums[mid] > value) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        
        return low;
    }
}
