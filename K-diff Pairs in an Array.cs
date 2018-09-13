public class Solution {
    public int FindPairs(int[] nums, int k) {
        if (k < 0) {
            return 0;
        }
        
        var map = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (map.ContainsKey(num)) {
                map[num]++;
            } else {
                map[num] = 1;
            }
        }
        
        var cnt = 0;
        foreach (var entity in map) {
            if (k == 0) {
                if (entity.Value > 1) {
                    cnt++;
                }
            } else {
                if (map.ContainsKey(entity.Key + k)) {
                    cnt++;
                }
            }
        }
        
        return cnt;
    }
}
