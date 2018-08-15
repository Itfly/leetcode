public class Solution {
    public int FirstMissingPositive(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 1;
        }
        
        for (var i = 0; i < nums.Length; i++) {
            while (nums[i] != i + 1) {
                if (nums[i] <= 0 || nums[i] >= nums.Length || nums[i] == nums[nums[i] - 1]) {
                    break;
                }
                
                var temp = nums[i];
                nums[i] = nums[temp - 1];
                nums[temp - 1] = temp;
            }
        }
        
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] != i + 1) {
                return i + 1;
            }
        }
        
        return nums.Length + 1;
    }
}
