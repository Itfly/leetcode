public class Solution {
    public int MissingNumber(int[] nums) {
        var xor = nums.Length;
        for (var i = 0; i < nums.Length; i++) {
            xor ^= i;
            xor ^= nums[i];
        }
        
        return xor;
    }
}
