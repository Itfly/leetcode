public class Solution {
    public void NextPermutation(int[] nums) {
        if (nums == null || nums.Length <= 1) {
            return;
        }
        
        var i = nums.Length - 2;
        var j = nums.Length - 1;
        while (i >= 0 && nums[i] >= nums[j]) {
            i--;
            j--;
        }
        
        if (i < 0) {
            Array.Reverse(nums);
            return;
        }
        
        var k = nums.Length - 1;
        while (nums[i] >= nums[k]) {
            k--;
        }
        var temp = nums[i];
        nums[i] = nums[k];
        nums[k] = temp;
        Array.Reverse(nums, j, nums.Length - j);
    }
}
