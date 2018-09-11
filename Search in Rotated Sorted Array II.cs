public class Solution {
    public bool Search(int[] nums, int target) {
        var low = 0;
        var high = nums.Length - 1;
        while (low <= high) {
            var mid = low + (high - low) / 2;
            if (nums[mid] == target) {
                return true;
            }
            
            if (nums[low] < nums[mid]) {
                if (nums[mid] > target && nums[low] <= target) {
                    high = mid - 1;
                } else {
                    low = mid + 1;
                }
            } else if (nums[low] > nums[mid]) {
                if (nums[mid] < target && target <= nums[high]) {
                    low = mid + 1;
                } else {
                    high = mid - 1;
                }
            } else {
                low++;
            }
        }
        
        return false;
    }
}
