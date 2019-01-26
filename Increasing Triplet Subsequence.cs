public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        if (nums == null || nums.Length < 3) {
            return false;
        }
        
        var x = int.MaxValue; // minimal number in the current nums
        var y = int.MaxValue; // there's at least one smaller num before itself because of the 'else if' setence
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
