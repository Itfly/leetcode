public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        var last = 1;
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[last++] = nums[i];
            }
        }
        return last;
    }
}
