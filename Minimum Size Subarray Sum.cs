public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        var len = nums.Length + 1;
        var i = 0;
        var j = 0;
        var sum = 0;
        while (j < nums.Length) {
            while (sum < s && j < nums.Length) {
                sum += nums[j++];
            }
            while (sum >= s) {
                len = Math.Min(len, j - i);
                sum -= nums[i++];
            }
        }
        
        return len > nums.Length ? 0 : len;
    }
}
