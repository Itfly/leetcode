public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return nums;
        }
        
        var result = new int[nums.Length];
        result[0] = 1;
        for (var i = 1; i < nums.Length; i++) {
            result[i] = result[i - 1] * nums[i - 1];
        }
        
        var product = 1;
        for (var i = nums.Length - 1; i >= 0; i--) {
            result[i] *= product;
            product *= nums[i];
        }
        
        return result;
    }
}
