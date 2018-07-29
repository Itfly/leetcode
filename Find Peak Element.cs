public class Solution {
    public int FindPeakElement(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return -1;
        }
        
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right) {
            var mid = left + (right - left) / 2;
            if ((mid == 0 || nums[mid] >= nums[mid - 1]) &&
                (mid == nums.Length - 1 || nums[mid] >= nums[mid + 1])) {
                return mid;
            } else if (mid > 0 &&  nums[mid - 1] > nums[mid]) {
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        return -1;
    }
}

// Better solution: https://leetcode.com/problems/find-peak-element/discuss/50239/Java-solution-and-explanation-using-invariants
