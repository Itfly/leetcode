public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = 0;
        var i = 0;        
        while (i < nums.Length) {
            while (i < nums.Length && nums[i] != 1) {
                i++;
            }
            if (i == nums.Length) {
                break;
            }
            
            var last = i++;
            while (i < nums.Length && nums[i] == 1) {
                i++;
            }
            max = Math.Max(max, i - last);
        }
        return max;
    }
}
