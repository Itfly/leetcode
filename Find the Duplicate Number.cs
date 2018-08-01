public class Solution {
    // https://leetcode.com/articles/find-the-duplicate-number/
    public int FindDuplicate(int[] nums) {
        // Get the cross location
        var i = nums[0];
        var j = nums[0];
        do {
            i = nums[i];
            j = nums[nums[j]];
        } while (i != j);
        
        // find the entrance to the cycle
        i = nums[0];
        while (i != j) {
            i = nums[i];
            j = nums[j];
        }
        
        return i;
    }
}
