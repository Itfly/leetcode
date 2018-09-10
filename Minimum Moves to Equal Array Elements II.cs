public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        var i = 0;
        var j = nums.Length - 1;
        var result = 0;
        while (i < j) {
            result += nums[j--] - nums[i++];
        }
        
        return result;
    }
}
