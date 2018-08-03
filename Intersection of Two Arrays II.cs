public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        
        var result = new List<int>();
        var i = 0;
        var j = 0;
        while (i < nums1.Length && j < nums2.Length) {
            if (nums1[i] < nums2[j]) {
                i++;
            } else if (nums1[i] == nums2[j]) {
                result.Add(nums1[i]);
                i++;
                j++;
            } else {
                j++;
            }
        }
        
        return result.ToArray();
    }
    
    // Hashmap
    public int[] Intersect(int[] nums1, int[] nums2) {
        var map1 = new Dictionary<int, int>();
        foreach (var num in nums1) {
            if (map1.ContainsKey(num)) {
                ++map1[num];
            } else {
                map1[num] = 1;
            }
        }
        
        var map2 = new Dictionary<int, int>();
        foreach (var num in nums2) {
            if (map1.ContainsKey(num) && map1[num] > 0) {
                if (map2.ContainsKey(num)) {
                    ++map2[num];
                } else {
                    map2[num] = 1;
                }
                --map1[num];
            }
        }
        
        var result = new List<int>();
        foreach (var entry in map2) {
            for (var i = 0; i < entry.Value; i++) {
                result.Add(entry.Key);
            }
        }
        return result.ToArray();
    }
}
