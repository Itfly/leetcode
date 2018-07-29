public class Solution {
    public int FindMin(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return -1;
        }
        
        if (nums.Length == 1) {
            return nums[0];
        }
        
        var left = 0; 
        var right = nums.Length - 1;
        while (left <= right) {
            if (nums[left] <= nums[right]) {
                return nums[left];
            }
            
            var mid = left + (right - left) / 2;
            if (nums[mid] >= nums[left]) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        return -1; // never go through here
    }
}
