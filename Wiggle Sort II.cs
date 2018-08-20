public class Solution {
    public void WiggleSort(int[] nums) {
        if (nums == null || nums.Length <= 1) {
            return;
        }
        
        Array.Sort(nums);
        var temp = new int[nums.Length];
        var left = (nums.Length - 1) / 2;
        var right = nums.Length - 1;
        
        for (var i = 0; i < nums.Length; i++) {
            if ((i & 1) == 0) {
                temp[i] = nums[left--];
            } else {
                temp[i] = nums[right--];
            }
        }
        
        Array.Copy(temp, 0, nums, 0, nums.Length);
    }
}
