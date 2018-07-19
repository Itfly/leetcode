public class Solution {
    public int Search(int[] nums, int target) {
        if (nums == null || nums.Length == 0) {
            return -1;
        }
        
        var i = 0;
        var j = nums.Length - 1;
        while (i <= j) {
            var mid = (i + j) / 2;
            if (nums[mid] == target) {
                return mid;
            } else if (nums[mid] > target) {
                j = mid - 1;
            } else {
                i = mid + 1;
            }
        }
        return -1;
    }
}
