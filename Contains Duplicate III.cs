public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if (nums == null || nums.Length < 2 || k < 0 || t < 0) {
            return false;
        }
        
        var set = new SortedSet<long>();
        for (var i = 0; i < nums.Length; i++) {
            var cur = (long) nums[i];
            var lowerValue = cur - t;
            var upperValue = cur + t;
            var sub = set.GetViewBetween(lowerValue, upperValue);
            if (sub.Count > 0) {
                return true;
            }
            
            set.Add(cur);
            if (i >= k) {
                set.Remove((long) nums[i - k]);
            }
        }
        
        return false;
    }
}
