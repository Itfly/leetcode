public class Solution {
    public int DominantIndex(int[] nums) {
        int first = nums[0];
        int second = Int32.MinValue;
        int max = 0;
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i] > first) {
                second = first;
                first = nums[i];
                max = i;
            } else if (nums[i] > second) {
                second = nums[i];
            }
        }
        
        if (first >= 2 * second) {
            return max;
        } else {
            return -1;
        }
    }
}
