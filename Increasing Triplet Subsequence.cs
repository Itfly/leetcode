public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        if (nums == null || nums.Length < 3) {
            return false;
        }
        
        var x = int.MaxValue;
        var y = int.MaxValue;
        for (var i = 0; i < nums.Length; i++) {
            var z = nums[i];
            if (x >= z) {
                x = z;
            } else if (y >= z) {
                y = z;
            } else {
                return true;
            }
        }
        
        return false;
    }
}
