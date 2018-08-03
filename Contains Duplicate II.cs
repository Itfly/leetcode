public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if (nums == null || nums.Length < 2 || k == 0) {
            return false;
        }
        
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++) {
            if (map.ContainsKey(nums[i])) {
                int pre = map[nums[i]];
                if (i - pre <= k) {
                    return true;
                }
            }
            map[nums[i]] = i;
        }
        
        return false;
    }
}
