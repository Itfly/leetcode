public class Solution {
    public int MaxProduct(int[] nums) {
        var max = new int[nums.Length];
        var min = new int[nums.Length];
        
        max[0] = min[0] = nums[0];
        var result = max[0];
        
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i] > 0) {
                max[i] = Math.Max(nums[i], max[i - 1] * nums[i]);
                min[i] = Math.Min(nums[i], min[i - 1] * nums[i]);
            } else {
                max[i] = Math.Max(nums[i], min[i - 1] * nums[i]);
                min[i] = Math.Min(nums[i], max[i - 1] * nums[i]); 
            }
            
            result = Math.Max(result, max[i]);
        }
        
        return result;
    }
}
