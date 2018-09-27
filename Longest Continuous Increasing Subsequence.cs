public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        var max = 1;
        var cnt = 1;
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i] > nums[i - 1]) {
                cnt++;
                max = Math.Max(max, cnt);
            } else {
                cnt = 1;
            }
        }
        
        return max;
    }
}
