public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        var sum = 0;
        map[0] = -1;
        for (var i = 0; i < nums.Length; i++) {
            sum += nums[i];
            if (k != 0) {  // In case k equals to 0, and nums is {0, 0}
                sum %= k;
            }
            
            if (map.ContainsKey(sum)) {
                if (i - map[sum] > 1) {
                    return true;
                } 
            } else {
                map[sum] = i;
            }
        }
        
        return false;
    }
}
