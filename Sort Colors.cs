public class Solution {
    public void SortColors(int[] nums) {
        if (nums == null || nums.Length <= 1) {
            return;
        }
        
        var i = 0; 
        var start = 0;
        var end = nums.Length - 1;
        while (i <= end) {
            if (nums[i] == 0) {
                nums[i] = nums[start];
                nums[start++] = 0;
            }
            if (nums[i] == 2) {
                nums[i] = nums[end];
                nums[end--] = 2;
            } else {
                i++;
            }
        }
    }
}
