public class Solution {
    public int PivotIndex(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return -1;
        }

        int sum = 0;
        int leftSum = 0;
        foreach(var num in nums) {
            sum += num;
        }
        
        for (var i = 0; i < nums.Length; i++) {
            if (leftSum == sum - leftSum - nums[i]) {
                return i;
            }
            leftSum += nums[i];
        }
        
        return -1;
    }
}
