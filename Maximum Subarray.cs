public class Solution {
    public int MaxSubArray(int[] nums) {
        var result = int.MinValue;
        var last = -1;
        for (var i = 0; i < nums.Length; i++) {
            if (last <= 0) {
                last = nums[i];
            } else {
                last += nums[i];
            }
            result = Math.Max(result, last);
        }
        
        return result;
    }
}
