public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var sum = 0;
        var result = 0;
        var map = new Dictionary<int, int>();
        map[0] = 1;
        
        foreach (var num in nums) {
            sum += num;
            if (map.ContainsKey(sum - k)) {
                result += map[sum - k];
            }
            
            if (map.ContainsKey(sum)) {
                map[sum]++;
            } else {
                map[sum] = 1;
            }
        }
        
        return result;
    }
}
