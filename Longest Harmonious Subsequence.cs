public class Solution {
    public int FindLHS(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        var max = 0;
        var map = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (map.ContainsKey(num)) {
                map[num]++;
            } else {
                map[num] = 1;
            }
        }
        
        foreach (var entity in map) {
            if (map.ContainsKey(entity.Key + 1)) {
                max = Math.Max(max, map[entity.Key + 1] + entity.Value);
            }
        }
        
        return max;
    }
}
