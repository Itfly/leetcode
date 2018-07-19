public class Solution {
    public void MoveZeroes(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return;
        }
        
        var i = 0;
        while (i < nums.Length && nums[i] != 0) {
            ++i;
        }
                
        for (var j = i + 1; j < nums.Length; j++) {
           if (nums[j] != 0) {
               nums[i++] = nums[j];
               nums[j] = 0;
           } 
        }
    }
}
