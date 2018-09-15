public class Solution {
    public int[] FindErrorNums(int[] nums) {
        var result = new int[2];
        var flag = 0;
        
        for (var i = 0; i < nums.Length; i++) {
            flag ^= nums[i] ^ (i + 1);
        }
        
        flag &= -flag; // get the last significant set bit
        
        for (var i = 0; i < nums.Length; i++) {
            if ((nums[i] & flag) == 0) {
                result[0] ^= nums[i];
            } else {
                result[1] ^= nums[i];    
            }
            if (((i + 1) & flag) == 0) {
                result[0] ^= i + 1;
            } else {
                result[1] ^= i + 1;
            }
        }
        
        foreach (var num in nums) {
            if (num == result[0]) {
                return result;
            }
        }
        
        return new int[2] {result[1], result[0]};
    }
}
