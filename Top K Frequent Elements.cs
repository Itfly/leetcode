public class Solution {
    // bucket sort
    public IList<int> TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (map.ContainsKey(num)) {
                ++map[num];
            } else {
                map[num] = 1;
            }
        }
        
        int max = 0;
        foreach (var entry in map) {
            max = Math.Max(max, entry.Value);
        }
        
        var buckets = new IList<int>[max + 1];
        for (var i = 1; i <= max; i++) {
            buckets[i] = new List<int>();
        }
        
        foreach (var entry in map) {
            buckets[entry.Value].Add(entry.Key);
        }
        
        var result = new List<int>(k);
        for (var j = max; j >= 1; j--) {
            foreach (var num in buckets[j]) {
                result.Add(num);
                if (result.Count == k) {
                    return result;
                }
            }
        }
        
        return result;
    }
}
