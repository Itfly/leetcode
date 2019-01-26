public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        var ranges = new int[] {-1, -1};
        if (nums == null || nums.Length == 0) {
            return ranges;
        }
        
        var low = 0;
        var high = nums.Length - 1;
        
        // search left range first
        while (low <= high) {
            var mid = low + (high - low) / 2;
            if (nums[mid] == target) {
                if (mid == 0 || nums[mid - 1] < target) {
                    ranges[0] = mid;
                    break;
                } else {
                    high = mid - 1;
                }
            } else if (nums[mid] > target) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        
        // search right range
        if (ranges[0] == -1) {
            return ranges;
        }
        ranges[1] = ranges[0];
        low = ranges[0] + 1;
        high = nums.Length - 1;
        while (low <= high) {
            var mid = low + (high - low) / 2;
            if (nums[mid] == target) {
                if (mid == nums.Length - 1 || nums[mid + 1] > target) {
                    ranges[1] = mid;
                    break;
                } else {
                    low = mid + 1;
                }
            } else if (nums[mid] > target) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        
        return ranges;
    }
}
