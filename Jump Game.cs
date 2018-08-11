public class Solution {
    public bool CanJump(int[] nums) {
        var last = 0;
        for (var i = 0; i < nums.Length; i++) {
            if (i > last) {
                return false;
            }
            last = Math.Max(last, i + nums[i]);
        }
        
        return true;
    }
}
